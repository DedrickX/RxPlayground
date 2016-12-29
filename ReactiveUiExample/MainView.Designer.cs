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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdditionResult = new System.Windows.Forms.TextBox();
            this.TxtNumber2 = new System.Windows.Forms.TextBox();
            this.TxtNumber1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtMeno
            // 
            this.TxtMeno.Location = new System.Drawing.Point(6, 37);
            this.TxtMeno.Name = "TxtMeno";
            this.TxtMeno.Size = new System.Drawing.Size(118, 20);
            this.TxtMeno.TabIndex = 1;
            // 
            // TxtPriezvisko
            // 
            this.TxtPriezvisko.Location = new System.Drawing.Point(143, 37);
            this.TxtPriezvisko.Name = "TxtPriezvisko";
            this.TxtPriezvisko.Size = new System.Drawing.Size(123, 20);
            this.TxtPriezvisko.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priezvisko";
            // 
            // LblCeleMeno
            // 
            this.LblCeleMeno.AutoSize = true;
            this.LblCeleMeno.Location = new System.Drawing.Point(72, 66);
            this.LblCeleMeno.Name = "LblCeleMeno";
            this.LblCeleMeno.Size = new System.Drawing.Size(69, 13);
            this.LblCeleMeno.TabIndex = 5;
            this.LblCeleMeno.Text = "LblCeleMeno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Celé meno:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtMeno);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPriezvisko);
            this.groupBox1.Controls.Add(this.LblCeleMeno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spojenie dvoch stringov";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtAdditionResult);
            this.groupBox2.Controls.Add(this.TxtNumber2);
            this.groupBox2.Controls.Add(this.TxtNumber1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 61);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spočítanie čísel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "+";
            // 
            // TxtAdditionResult
            // 
            this.TxtAdditionResult.Enabled = false;
            this.TxtAdditionResult.Location = new System.Drawing.Point(196, 25);
            this.TxtAdditionResult.Name = "TxtAdditionResult";
            this.TxtAdditionResult.Size = new System.Drawing.Size(70, 20);
            this.TxtAdditionResult.TabIndex = 4;
            // 
            // TxtNumber2
            // 
            this.TxtNumber2.Location = new System.Drawing.Point(101, 25);
            this.TxtNumber2.Name = "TxtNumber2";
            this.TxtNumber2.Size = new System.Drawing.Size(70, 20);
            this.TxtNumber2.TabIndex = 2;
            // 
            // TxtNumber1
            // 
            this.TxtNumber1.Location = new System.Drawing.Point(6, 25);
            this.TxtNumber1.Name = "TxtNumber1";
            this.TxtNumber1.Size = new System.Drawing.Size(70, 20);
            this.TxtNumber1.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainView";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMeno;
        private System.Windows.Forms.TextBox TxtPriezvisko;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblCeleMeno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdditionResult;
        private System.Windows.Forms.TextBox TxtNumber2;
        private System.Windows.Forms.TextBox TxtNumber1;
    }
}

