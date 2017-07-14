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
            this.BtnPaginatedAsyncSearchBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnTextChangedExample
            // 
            this.BtnTextChangedExample.Location = new System.Drawing.Point(12, 124);
            this.BtnTextChangedExample.Name = "BtnTextChangedExample";
            this.BtnTextChangedExample.Size = new System.Drawing.Size(192, 23);
            this.BtnTextChangedExample.TabIndex = 0;
            this.BtnTextChangedExample.Text = "TextChanged Event Example";
            this.BtnTextChangedExample.UseVisualStyleBackColor = true;
            this.BtnTextChangedExample.Click += new System.EventHandler(this.BtnTextChangedExample_Click);
            // 
            // BtnSchedulers
            // 
            this.BtnSchedulers.Location = new System.Drawing.Point(12, 153);
            this.BtnSchedulers.Name = "BtnSchedulers";
            this.BtnSchedulers.Size = new System.Drawing.Size(192, 57);
            this.BtnSchedulers.TabIndex = 1;
            this.BtnSchedulers.Text = "Test...";
            this.BtnSchedulers.UseVisualStyleBackColor = true;
            this.BtnSchedulers.Click += new System.EventHandler(this.BtnSchedulers_Click);
            // 
            // BtnAsyncSearchBox
            // 
            this.BtnAsyncSearchBox.Location = new System.Drawing.Point(12, 11);
            this.BtnAsyncSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAsyncSearchBox.Name = "BtnAsyncSearchBox";
            this.BtnAsyncSearchBox.Size = new System.Drawing.Size(192, 23);
            this.BtnAsyncSearchBox.TabIndex = 2;
            this.BtnAsyncSearchBox.Text = "Async SearchBox";
            this.BtnAsyncSearchBox.UseVisualStyleBackColor = true;
            this.BtnAsyncSearchBox.Click += new System.EventHandler(this.BtnAsyncSearchBox_Click);
            // 
            // BtnPaginatedAsyncSearchBox
            // 
            this.BtnPaginatedAsyncSearchBox.Location = new System.Drawing.Point(12, 38);
            this.BtnPaginatedAsyncSearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPaginatedAsyncSearchBox.Name = "BtnPaginatedAsyncSearchBox";
            this.BtnPaginatedAsyncSearchBox.Size = new System.Drawing.Size(192, 23);
            this.BtnPaginatedAsyncSearchBox.TabIndex = 3;
            this.BtnPaginatedAsyncSearchBox.Text = "Paginated Async SearchBox";
            this.BtnPaginatedAsyncSearchBox.UseVisualStyleBackColor = true;
            this.BtnPaginatedAsyncSearchBox.Click += new System.EventHandler(this.BtnPaginatedAsyncSearchBox_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 345);
            this.Controls.Add(this.BtnPaginatedAsyncSearchBox);
            this.Controls.Add(this.BtnAsyncSearchBox);
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
        private System.Windows.Forms.Button BtnAsyncSearchBox;
        private System.Windows.Forms.Button BtnPaginatedAsyncSearchBox;
    }
}

