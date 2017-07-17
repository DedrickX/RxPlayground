namespace RxCsPlayground.Cities
{
    partial class FrmCities
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
            this.LblProgressInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListResults = new System.Windows.Forms.ListBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblProgressInfo
            // 
            this.LblProgressInfo.AutoSize = true;
            this.LblProgressInfo.Location = new System.Drawing.Point(59, 33);
            this.LblProgressInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProgressInfo.Name = "LblProgressInfo";
            this.LblProgressInfo.Size = new System.Drawing.Size(80, 13);
            this.LblProgressInfo.TabIndex = 2;
            this.LblProgressInfo.Text = "LblProgressInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Results";
            // 
            // ListResults
            // 
            this.ListResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListResults.FormattingEnabled = true;
            this.ListResults.IntegralHeight = false;
            this.ListResults.Location = new System.Drawing.Point(62, 63);
            this.ListResults.Margin = new System.Windows.Forms.Padding(2);
            this.ListResults.Name = "ListResults";
            this.ListResults.Size = new System.Drawing.Size(310, 308);
            this.ListResults.TabIndex = 4;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtSearch.Location = new System.Drawing.Point(62, 11);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(310, 20);
            this.TxtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // FrmCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 382);
            this.Controls.Add(this.LblProgressInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ListResults);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmCities";
            this.Text = "FrmCities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProgressInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ListResults;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label1;
    }
}