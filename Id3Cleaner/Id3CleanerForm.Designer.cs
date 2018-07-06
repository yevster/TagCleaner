namespace Id3Cleaner
{
    partial class CleanerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CleanerForm));
            this.dlgDirectorySelect = new System.Windows.Forms.FolderBrowserDialog();
            this.lstTitles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtCurrentDirectory = new System.Windows.Forms.TextBox();
            this.txtStringToRemove = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstTitles
            // 
            this.lstTitles.FormattingEnabled = true;
            this.lstTitles.HorizontalScrollbar = true;
            this.lstTitles.Location = new System.Drawing.Point(15, 12);
            this.lstTitles.Name = "lstTitles";
            this.lstTitles.Size = new System.Drawing.Size(571, 303);
            this.lstTitles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "String to Remove:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(352, 399);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(110, 37);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(471, 399);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 37);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtCurrentDirectory
            // 
            this.txtCurrentDirectory.Location = new System.Drawing.Point(119, 335);
            this.txtCurrentDirectory.Name = "txtCurrentDirectory";
            this.txtCurrentDirectory.ReadOnly = true;
            this.txtCurrentDirectory.Size = new System.Drawing.Size(467, 20);
            this.txtCurrentDirectory.TabIndex = 5;
            // 
            // txtStringToRemove
            // 
            this.txtStringToRemove.Location = new System.Drawing.Point(119, 364);
            this.txtStringToRemove.Name = "txtStringToRemove";
            this.txtStringToRemove.Size = new System.Drawing.Size(467, 20);
            this.txtStringToRemove.TabIndex = 1;
            this.txtStringToRemove.TextChanged += new System.EventHandler(this.txtStringToRemove_TextChanged);
            // 
            // CleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 464);
            this.Controls.Add(this.txtStringToRemove);
            this.Controls.Add(this.txtCurrentDirectory);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTitles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CleanerForm";
            this.Text = "ID3 Cleaner";
            this.Load += new System.EventHandler(this.CleanerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog dlgDirectorySelect;
        private System.Windows.Forms.ListBox lstTitles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtCurrentDirectory;
        private System.Windows.Forms.TextBox txtStringToRemove;
    }
}

