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
            this.BtnAsyncSearchBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTextChangedExample
            // 
            this.BtnTextChangedExample.Location = new System.Drawing.Point(18, 18);
            this.BtnTextChangedExample.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnTextChangedExample.Name = "BtnTextChangedExample";
            this.BtnTextChangedExample.Size = new System.Drawing.Size(288, 35);
            this.BtnTextChangedExample.TabIndex = 0;
            this.BtnTextChangedExample.Text = "TextChanged Event Example";
            this.BtnTextChangedExample.UseVisualStyleBackColor = true;
            this.BtnTextChangedExample.Click += new System.EventHandler(this.BtnTextChangedExample_Click);
            // 
            // BtnSchedulers
            // 
            this.BtnSchedulers.Location = new System.Drawing.Point(18, 125);
            this.BtnSchedulers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnSchedulers.Name = "BtnSchedulers";
            this.BtnSchedulers.Size = new System.Drawing.Size(288, 35);
            this.BtnSchedulers.TabIndex = 1;
            this.BtnSchedulers.Text = "Schedulers";
            this.BtnSchedulers.UseVisualStyleBackColor = true;
            this.BtnSchedulers.Click += new System.EventHandler(this.BtnSchedulers_Click);
            // 
            // BtnAsyncSearchBox
            // 
            this.BtnAsyncSearchBox.Location = new System.Drawing.Point(18, 61);
            this.BtnAsyncSearchBox.Name = "BtnAsyncSearchBox";
            this.BtnAsyncSearchBox.Size = new System.Drawing.Size(288, 35);
            this.BtnAsyncSearchBox.TabIndex = 2;
            this.BtnAsyncSearchBox.Text = "Async SearchBox";
            this.BtnAsyncSearchBox.UseVisualStyleBackColor = true;
            this.BtnAsyncSearchBox.Click += new System.EventHandler(this.BtnAsyncSearchBox_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 531);
            this.Controls.Add(this.BtnAsyncSearchBox);
            this.Controls.Add(this.BtnSchedulers);
            this.Controls.Add(this.BtnTextChangedExample);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnTextChangedExample;
        private System.Windows.Forms.Button BtnSchedulers;
        private System.Windows.Forms.Button BtnAsyncSearchBox;
    }
}

