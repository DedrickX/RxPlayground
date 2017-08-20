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
            this.ListResults = new System.Windows.Forms.ListBox();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblProgressInfo
            // 
            this.LblProgressInfo.AutoSize = true;
            this.LblProgressInfo.Location = new System.Drawing.Point(11, 80);
            this.LblProgressInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblProgressInfo.Name = "LblProgressInfo";
            this.LblProgressInfo.Size = new System.Drawing.Size(80, 13);
            this.LblProgressInfo.TabIndex = 2;
            this.LblProgressInfo.Text = "LblProgressInfo";
            // 
            // ListResults
            // 
            this.ListResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListResults.FormattingEnabled = true;
            this.ListResults.IntegralHeight = false;
            this.ListResults.Location = new System.Drawing.Point(11, 108);
            this.ListResults.Margin = new System.Windows.Forms.Padding(2);
            this.ListResults.Name = "ListResults";
            this.ListResults.Size = new System.Drawing.Size(361, 304);
            this.ListResults.TabIndex = 3;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtSearch.Location = new System.Drawing.Point(11, 58);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(239, 20);
            this.TxtSearch.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(255, 57);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(116, 23);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Hľadaj mesto";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 47);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zoznam miest je napĺňaný asynchrónne. \r\n- Počas napĺňania údajov je možné s formu" +
    "lárom ľubovoľne pracovať.\r\n- Hľadanie funguje tak, že vyfiltruje mestá obsahujúc" +
    "e zadaný reťazec\r\n";
            // 
            // FrmCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblProgressInfo);
            this.Controls.Add(this.ListResults);
            this.Controls.Add(this.TxtSearch);
            this.Name = "FrmCities";
            this.Text = "FrmCities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProgressInfo;
        private System.Windows.Forms.ListBox ListResults;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label2;
    }
}