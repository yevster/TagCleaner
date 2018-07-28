﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Id3Cleaner
{
    public partial class CleanerForm : Form
    {

        /*
         * The map of files to tag titles in the current directory. Need to keep this around 
         * so as to not impact files added after directory contents have been listed.
         */
        private IDictionary<string, string> titlesToFiles;

        public CleanerForm()
        {
            InitializeComponent();
        }

        private void CleanerForm_Load(object sender, EventArgs e)
        {
            string curDir = Directory.GetCurrentDirectory();
            dlgDirectorySelect.SelectedPath = curDir;
            showDirectory(curDir);
        }

        private void showDirectory(string dir)
        {
            lstTitles.Items.Clear();
            titlesToFiles = getTilesInDirectory(dir);
            foreach (string title in titlesToFiles.Keys) lstTitles.Items.Add(title);
            for (int i = 0; i < lstTitles.Items.Count; ++i) lstTitles.SetSelected(i, true);
            txtCurrentDirectory.Text = dir;
            updateRemoveButton();
        }

        /// <summary>
        /// Returns a dictionary mapping file paths to ID3 titles
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        private static IDictionary<string, string> getTilesInDirectory(string dir)
        {
            var result = new Dictionary<string, string>();
            foreach (string file in Directory.GetFiles(dir))
            {
                try
                {
                    var tags = TagLib.File.Create(file);
                    string title = tags.Tag.Title;
                    if (!string.IsNullOrEmpty(title))
                    {
                        result.Add(title, file);
                    }
                }
                catch (TagLib.UnsupportedFormatException)
                {
                    Debug.WriteLine($"File {file} is not supported");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Unable to read file {file}. {e.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result.ToImmutableDictionary();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var selected = dlgDirectorySelect.ShowDialog();
            if (selected == DialogResult.OK)
            {
                showDirectory(dlgDirectorySelect.SelectedPath);
            }
        }

        private void txtStringToRemove_TextChanged(object sender, EventArgs e)
        {
            updateRemoveButton();
        }

        private void updateRemoveButton()
        {
            btnRemove.Enabled = txtStringToRemove.Text.Length > 0 && lstTitles.Items.Count > 0;
        }

        private void btnRemove_Click(object sender, EventArgs eventArgs)
        {
            foreach (string oldTitle in lstTitles.SelectedItems.Cast<string>())
            {
                string file = titlesToFiles[oldTitle];
                try
                {
                    var tags = TagLib.File.Create(file);
                    if (oldTitle.StartsWith(txtStringToRemove.Text))
                    {
                        string newTitle = oldTitle.Remove(0, txtStringToRemove.Text.Length);
                        tags.Tag.Title = newTitle;
                        tags.Save();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Unable to edit file {file}. {e.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            showDirectory(dlgDirectorySelect.SelectedPath);
        }

        private void lstTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var titles = lstTitles.SelectedItems.Cast<string>();
            txtStringToRemove.Text = GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(titles);
        }
    }
}
