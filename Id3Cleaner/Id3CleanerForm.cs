﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Id3Cleaner
{
    public partial class CleanerForm : Form
    {

        /*
         * The map of files to tag titles in the current directory. Need to keep this around 
         * so as to not impact files added after directory contents have been listed.
         */
        private IDictionary<string, string> filesToTitlesMap;

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
            filesToTitlesMap = getTilesInDirectory(dir);
            foreach (string title in filesToTitlesMap.Values) lstTitles.Items.Add(title);
            txtCurrentDirectory.Text = dir;
            txtStringToRemove.Text = GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(filesToTitlesMap.Values);
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
                        result.Add(file, title);
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
            foreach (string file in filesToTitlesMap.Keys)
            {
                try
                {
                    var tags = TagLib.File.Create(file);
                    string oldtitle = filesToTitlesMap[file];
                    if (oldtitle.StartsWith(txtStringToRemove.Text))
                    {
                        string newTitle = oldtitle.Remove(0, txtStringToRemove.Text.Length);
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
    }
}