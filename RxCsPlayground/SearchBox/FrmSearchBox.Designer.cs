namespace RxCsPlayground
{
    partial class FrmSearchBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.ListResults = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDebug = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(88, 12);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(376, 26);
            this.TxtSearch.TabIndex = 1;
            // 
            // ListResults
            // 
            this.ListResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListResults.FormattingEnabled = true;
            this.ListResults.IntegralHeight = false;
            this.ListResults.ItemHeight = 20;
            this.ListResults.Location = new System.Drawing.Point(88, 44);
            this.ListResults.Name = "ListResults";
            this.ListResults.Size = new System.Drawing.Size(376, 560);
            this.ListResults.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results";
            // 
            // TxtDebug
            // 
            this.TxtDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDebug.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtDebug.Location = new System.Drawing.Point(476, 44);
            this.TxtDebug.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.TxtDebug.Name = "TxtDebug";
            this.TxtDebug.Size = new System.Drawing.Size(433, 560);
            this.TxtDebug.TabIndex = 4;
            this.TxtDebug.Text = "";
            // 
            // FrmSearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 616);
            this.Controls.Add(this.TxtDebug);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListResults);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmSearchBox";
            this.Text = "Search Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ListBox ListResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TxtDebug;
    }
}