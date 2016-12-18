namespace ReactiveUiExample
{
    partial class MainView
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
            this.TxtMeno = new System.Windows.Forms.TextBox();
            this.TxtPriezvisko = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblCeleMeno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtMeno
            // 
            this.TxtMeno.Location = new System.Drawing.Point(12, 32);
            this.TxtMeno.Name = "TxtMeno";
            this.TxtMeno.Size = new System.Drawing.Size(89, 20);
            this.TxtMeno.TabIndex = 0;
            // 
            // TxtPriezvisko
            // 
            this.TxtPriezvisko.Location = new System.Drawing.Point(107, 32);
            this.TxtPriezvisko.Name = "TxtPriezvisko";
            this.TxtPriezvisko.Size = new System.Drawing.Size(89, 20);
            this.TxtPriezvisko.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Priezvisko";
            // 
            // LblCeleMeno
            // 
            this.LblCeleMeno.AutoSize = true;
            this.LblCeleMeno.Location = new System.Drawing.Point(12, 66);
            this.LblCeleMeno.Name = "LblCeleMeno";
            this.LblCeleMeno.Size = new System.Drawing.Size(57, 13);
            this.LblCeleMeno.TabIndex = 4;
            this.LblCeleMeno.Text = "Celé meno";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 100);
            this.Controls.Add(this.LblCeleMeno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPriezvisko);
            this.Controls.Add(this.TxtMeno);
            this.Name = "MainView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMeno;
        private System.Windows.Forms.TextBox TxtPriezvisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCeleMeno;
    }
}

