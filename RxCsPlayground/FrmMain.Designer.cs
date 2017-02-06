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
            this.BtnTextChangedExample = new System.Windows.Forms.Button();
            this.BtnSchedulers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTextChangedExample
            // 
            this.BtnTextChangedExample.Location = new System.Drawing.Point(12, 12);
            this.BtnTextChangedExample.Name = "BtnTextChangedExample";
            this.BtnTextChangedExample.Size = new System.Drawing.Size(192, 23);
            this.BtnTextChangedExample.TabIndex = 0;
            this.BtnTextChangedExample.Text = "TextChanged Event Example";
            this.BtnTextChangedExample.UseVisualStyleBackColor = true;
            this.BtnTextChangedExample.Click += new System.EventHandler(this.BtnTextChangedExample_Click);
            // 
            // BtnSchedulers
            // 
            this.BtnSchedulers.Location = new System.Drawing.Point(12, 41);
            this.BtnSchedulers.Name = "BtnSchedulers";
            this.BtnSchedulers.Size = new System.Drawing.Size(192, 23);
            this.BtnSchedulers.TabIndex = 1;
            this.BtnSchedulers.Text = "Schedulers";
            this.BtnSchedulers.UseVisualStyleBackColor = true;
            this.BtnSchedulers.Click += new System.EventHandler(this.BtnSchedulers_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 345);
            this.Controls.Add(this.BtnSchedulers);
            this.Controls.Add(this.BtnTextChangedExample);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTextChangedExample;
        private System.Windows.Forms.Button BtnSchedulers;
    }
}

