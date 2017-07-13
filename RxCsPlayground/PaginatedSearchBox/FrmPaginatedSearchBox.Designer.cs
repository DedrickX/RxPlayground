namespace RxCsPlayground.PaginatedSearchBox
{
    partial class FrmPaginatedSearchBox
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
            this.LblProgressInfo = new System.Windows.Forms.Label();
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
            this.TxtSearch.Size = new System.Drawing.Size(814, 26);
            this.TxtSearch.TabIndex = 1;
            // 
            // ListResults
            // 
            this.ListResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListResults.FormattingEnabled = true;
            this.ListResults.IntegralHeight = false;
            this.ListResults.ItemHeight = 20;
            this.ListResults.Location = new System.Drawing.Point(88, 92);
            this.ListResults.Name = "ListResults";
            this.ListResults.Size = new System.Drawing.Size(814, 512);
            this.ListResults.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results";
            // 
            // LblProgressInfo
            // 
            this.LblProgressInfo.AutoSize = true;
            this.LblProgressInfo.Location = new System.Drawing.Point(88, 55);
            this.LblProgressInfo.Name = "LblProgressInfo";
            this.LblProgressInfo.Size = new System.Drawing.Size(121, 20);
            this.LblProgressInfo.TabIndex = 4;
            this.LblProgressInfo.Text = "LblProgressInfo";
            // 
            // FrmPaginatedSearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 615);
            this.Controls.Add(this.LblProgressInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListResults);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmPaginatedSearchBox";
            this.Text = "Paginated Search Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ListBox ListResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblProgressInfo;
    }
}