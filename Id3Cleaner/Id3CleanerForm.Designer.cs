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
            this.txtResultPreview = new System.Windows.Forms.TextBox();
            this.lblResultPreview = new System.Windows.Forms.Label();
            this.txtStringToPrepend = new System.Windows.Forms.TextBox();
            this.lblToPrepend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTitles
            // 
            this.lstTitles.FormattingEnabled = true;
            this.lstTitles.HorizontalScrollbar = true;
            this.lstTitles.ItemHeight = 24;
            this.lstTitles.Location = new System.Drawing.Point(28, 22);
            this.lstTitles.Margin = new System.Windows.Forms.Padding(6);
            this.lstTitles.Name = "lstTitles";
            this.lstTitles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTitles.Size = new System.Drawing.Size(1044, 556);
            this.lstTitles.Sorted = true;
            this.lstTitles.TabIndex = 0;
            this.lstTitles.SelectedIndexChanged += new System.EventHandler(this.lstTitles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 605);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Directory:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 654);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "String to Remove:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(645, 810);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(202, 68);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "&Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(864, 810);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(209, 68);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtCurrentDirectory
            // 
            this.txtCurrentDirectory.Location = new System.Drawing.Point(218, 602);
            this.txtCurrentDirectory.Margin = new System.Windows.Forms.Padding(6);
            this.txtCurrentDirectory.Name = "txtCurrentDirectory";
            this.txtCurrentDirectory.ReadOnly = true;
            this.txtCurrentDirectory.Size = new System.Drawing.Size(853, 29);
            this.txtCurrentDirectory.TabIndex = 5;
            // 
            // txtStringToRemove
            // 
            this.txtStringToRemove.Location = new System.Drawing.Point(218, 650);
            this.txtStringToRemove.Margin = new System.Windows.Forms.Padding(6);
            this.txtStringToRemove.Name = "txtStringToRemove";
            this.txtStringToRemove.Size = new System.Drawing.Size(853, 29);
            this.txtStringToRemove.TabIndex = 1;
            // 
            // txtResultPreview
            // 
            this.txtResultPreview.Enabled = false;
            this.txtResultPreview.Location = new System.Drawing.Point(218, 747);
            this.txtResultPreview.Margin = new System.Windows.Forms.Padding(6);
            this.txtResultPreview.Name = "txtResultPreview";
            this.txtResultPreview.Size = new System.Drawing.Size(853, 29);
            this.txtResultPreview.TabIndex = 6;
            // 
            // lblResultPreview
            // 
            this.lblResultPreview.AutoSize = true;
            this.lblResultPreview.Location = new System.Drawing.Point(23, 750);
            this.lblResultPreview.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResultPreview.Name = "lblResultPreview";
            this.lblResultPreview.Size = new System.Drawing.Size(135, 25);
            this.lblResultPreview.TabIndex = 7;
            this.lblResultPreview.Text = "Result Privew:";
            // 
            // txtStringToPrepend
            // 
            this.txtStringToPrepend.Location = new System.Drawing.Point(218, 694);
            this.txtStringToPrepend.Margin = new System.Windows.Forms.Padding(6);
            this.txtStringToPrepend.Name = "txtStringToPrepend";
            this.txtStringToPrepend.Size = new System.Drawing.Size(853, 29);
            this.txtStringToPrepend.TabIndex = 8;
            // 
            // txtStringToPrepend
            // 
            this.txtStringToPrepend.Location = new System.Drawing.Point(178, 578);
            this.txtStringToPrepend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStringToPrepend.Name = "txtStringToPrepend";
            this.txtStringToPrepend.Size = new System.Drawing.Size(698, 26);
            this.txtStringToPrepend.TabIndex = 8;
            this.txtStringToPrepend.TextChanged += new System.EventHandler(this.txtStringToPrepend_TextChanged);
            // 
            // lblToPrepend
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 698);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "String to Prepend:";
            // 
            // CleanerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1092, 900);
            this.Controls.Add(this.txtStringToPrepend);
            this.Controls.Add(this.lblToPrepend);
            this.Controls.Add(this.txtResultPreview);
            this.Controls.Add(this.lblResultPreview);
            this.Controls.Add(this.txtStringToRemove);
            this.Controls.Add(this.txtCurrentDirectory);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstTitles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "CleanerForm";
            this.Text = "Tag Cleaner";
            this.Load += new System.EventHandler(this.CleanerForm_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.CleanerForm_Layout);
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
        private System.Windows.Forms.TextBox txtResultPreview;
        private System.Windows.Forms.Label lblResultPreview;
        private System.Windows.Forms.TextBox txtStringToPrepend;
        private System.Windows.Forms.Label lblToPrepend;
    }
}

