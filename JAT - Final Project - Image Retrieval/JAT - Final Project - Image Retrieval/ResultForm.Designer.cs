﻿namespace JAT___Final_Project___Image_Retrieval
{
    partial class ResultForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.title1 = new JAT___Final_Project___Image_Retrieval.Title();
            this.showPicture = new JAT___Final_Project___Image_Retrieval.ShowPicture();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.title1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.showPicture);
            this.splitContainer1.Size = new System.Drawing.Size(917, 551);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // title1
            // 
            this.title1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title1.Location = new System.Drawing.Point(0, 0);
            this.title1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(915, 111);
            this.title1.TabIndex = 0;
            // 
            // showPicture
            // 
            this.showPicture.BackColor = System.Drawing.SystemColors.Control;
            this.showPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPicture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPicture.Location = new System.Drawing.Point(0, 0);
            this.showPicture.Margin = new System.Windows.Forms.Padding(2);
            this.showPicture.Name = "showPicture";
            this.showPicture.Size = new System.Drawing.Size(915, 435);
            this.showPicture.TabIndex = 0;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 551);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResultForm_FormClosed);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Title title1;
        private ShowPicture showPicture;
    }
}