namespace RxCsPlayground
{
    partial class FrmMain
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
            this.BtnSchedulers = new System.Windows.Forms.Button();
            this.BtnCities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSchedulers
            // 
            this.BtnSchedulers.Location = new System.Drawing.Point(309, 14);
            this.BtnSchedulers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSchedulers.Name = "BtnSchedulers";
            this.BtnSchedulers.Size = new System.Drawing.Size(288, 88);
            this.BtnSchedulers.TabIndex = 1;
            this.BtnSchedulers.Text = "Test...";
            this.BtnSchedulers.UseVisualStyleBackColor = true;
            this.BtnSchedulers.Click += new System.EventHandler(this.BtnSchedulers_Click);
            // 
            // BtnCities
            // 
            this.BtnCities.Location = new System.Drawing.Point(13, 14);
            this.BtnCities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCities.Name = "BtnCities";
            this.BtnCities.Size = new System.Drawing.Size(288, 88);
            this.BtnCities.TabIndex = 2;
            this.BtnCities.Text = "Zoznam miest a obcí";
            this.BtnCities.UseVisualStyleBackColor = true;
            this.BtnCities.Click += new System.EventHandler(this.BtnCities_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 531);
            this.Controls.Add(this.BtnCities);
            this.Controls.Add(this.BtnSchedulers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnSchedulers;
        private System.Windows.Forms.Button BtnCities;
    }
}

