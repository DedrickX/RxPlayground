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
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnCities = new System.Windows.Forms.Button();
            this.BtnInput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTest
            // 
            this.BtnTest.Location = new System.Drawing.Point(12, 160);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(192, 33);
            this.BtnTest.TabIndex = 1;
            this.BtnTest.Text = "Test...";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnCities
            // 
            this.BtnCities.Location = new System.Drawing.Point(12, 51);
            this.BtnCities.Name = "BtnCities";
            this.BtnCities.Size = new System.Drawing.Size(407, 33);
            this.BtnCities.TabIndex = 2;
            this.BtnCities.Text = "Zoznam miest a obcí - stránkovaný zdroj dát";
            this.BtnCities.UseVisualStyleBackColor = true;
            this.BtnCities.Click += new System.EventHandler(this.BtnCities_Click);
            // 
            // BtnInput
            // 
            this.BtnInput.Location = new System.Drawing.Point(12, 12);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(407, 33);
            this.BtnInput.TabIndex = 3;
            this.BtnInput.Text = "Písanie do textBoxu";
            this.BtnInput.UseVisualStyleBackColor = true;
            this.BtnInput.Click += new System.EventHandler(this.BtnInput_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 345);
            this.Controls.Add(this.BtnInput);
            this.Controls.Add(this.BtnCities);
            this.Controls.Add(this.BtnTest);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnCities;
        private System.Windows.Forms.Button BtnInput;
    }
}

