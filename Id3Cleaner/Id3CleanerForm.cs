using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Id3Cleaner
{
    public partial class CleanerForm : Form
    {

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
            var tracks = getTracksInDirectory(dir);
            lstTitles.DataSource = tracks;
            lstTitles.DisplayMember = "Title";
            for (int i = 0; i < lstTitles.Items.Count; ++i) lstTitles.SetSelected(i, true);
       
            updateRemoveButton();
        }

        /// <summary>
        /// Returns a dictionary mapping file paths to ID3 titles
        /// </summary>
        /// <param name="dir"></param>
        /// <returns></returns>
        private static IList<TrackData> getTracksInDirectory(string dir)
        {
            var result = new List<TrackData>();
            foreach (string file in Directory.GetFiles(dir))
            {
                try
                {
                    var tags = TagLib.File.Create(file);
                    string title = tags.Tag.Title;
                    if (!string.IsNullOrEmpty(title))
                    {
                        result.Add(new TrackData(title, file));
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
            return result.ToImmutableList();
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
            txtResultPreview.BackColor = txtCurrentDirectory.BackColor;
            if (lstTitles.SelectedItems?.Count > 0) {
                string oldTitle = lstTitles.SelectedItems.Cast<TrackData>().First().Title;
                string newTitle = getNewTitle(oldTitle);
                txtResultPreview.Text = newTitle;
                
                //If the string to remove is not present in the title, highlight the error condition.
                if (string.Equals(oldTitle, newTitle) && !string.IsNullOrEmpty(oldTitle))
                {
                    txtResultPreview.BackColor = Color.Red;
                } 
            }
            
            updateRemoveButton();
        }

        private void updateRemoveButton()
        {
            btnRemove.Enabled = txtStringToRemove.Text.Length > 0 && lstTitles.Items.Count > 0;
        }


        private string getNewTitle(string oldTitle)
        {
            return oldTitle.StartsWith(txtStringToRemove.Text) ? oldTitle.Remove(0, txtStringToRemove.Text.Length) : oldTitle;
        }

        private void btnRemove_Click(object sender, EventArgs eventArgs)
        {
            foreach (var track in lstTitles.SelectedItems.Cast<TrackData>())
            {
                string oldTitle = track.Title;
                
                try
                {
                    var tags = TagLib.File.Create(track.FilePath);
                    tags.Tag.Title = getNewTitle(oldTitle);
                    tags.Save();
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Unable to edit file {track.FilePath}. {e.Message}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            showDirectory(dlgDirectorySelect.SelectedPath);
        }

        private void lstTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            var titles = lstTitles.SelectedItems.Cast<TrackData>().Select(t => t.Title);
            txtStringToRemove.Text = GreatestCommonLeftSubstringFinder.FindGreatestCommonLeftSubstring(titles);
        }

        private void CleanerForm_Layout(object sender, LayoutEventArgs e)
        {
            //Make symmetric bottom and right margins
            int nonClientHeight = this.Height - this.ClientRectangle.Height;
            this.Height = nonClientHeight + btnBrowse.Bottom + lstTitles.Top;

            int nonClientWidth = this.Width - this.ClientRectangle.Width;
            this.Width = nonClientWidth + btnRemove.Right + lstTitles.Left;
        }
    }
}
