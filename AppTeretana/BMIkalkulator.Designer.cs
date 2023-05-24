namespace AppTeretana
{
    partial class BMIkalkulator
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
            this.richTextBoxBMI = new System.Windows.Forms.RichTextBox();
            this.txtBoxMasa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxTezina = new System.Windows.Forms.TextBox();
            this.btnIndeks = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(39, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi svoju masu:";
            // 
            // richTextBoxBMI
            // 
            this.richTextBoxBMI.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBoxBMI.Location = new System.Drawing.Point(44, 116);
            this.richTextBoxBMI.Name = "richTextBoxBMI";
            this.richTextBoxBMI.Size = new System.Drawing.Size(420, 177);
            this.richTextBoxBMI.TabIndex = 1;
            this.richTextBoxBMI.Text = "";
            // 
            // txtBoxMasa
            // 
            this.txtBoxMasa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxMasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxMasa.Location = new System.Drawing.Point(44, 72);
            this.txtBoxMasa.Name = "txtBoxMasa";
            this.txtBoxMasa.Size = new System.Drawing.Size(167, 23);
            this.txtBoxMasa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(288, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesi svoju tezinu:";
            // 
            // txtBoxTezina
            // 
            this.txtBoxTezina.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBoxTezina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtBoxTezina.Location = new System.Drawing.Point(293, 72);
            this.txtBoxTezina.Name = "txtBoxTezina";
            this.txtBoxTezina.Size = new System.Drawing.Size(171, 23);
            this.txtBoxTezina.TabIndex = 4;
            // 
            // btnIndeks
            // 
            this.btnIndeks.BackColor = System.Drawing.Color.OliveDrab;
            this.btnIndeks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnIndeks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnIndeks.Location = new System.Drawing.Point(164, 299);
            this.btnIndeks.Name = "btnIndeks";
            this.btnIndeks.Size = new System.Drawing.Size(177, 66);
            this.btnIndeks.TabIndex = 5;
            this.btnIndeks.Text = "Izracunaj indeks tjelesne mase";
            this.btnIndeks.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stranice na kojima možete kupiti razne suplemente:";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(11, 80);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(486, 327);
            this.webBrowser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(199, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(610, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "BMI kalkulator i Web preglednik";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxMasa);
            this.groupBox1.Controls.Add(this.txtBoxTezina);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnIndeks);
            this.groupBox1.Controls.Add(this.richTextBoxBMI);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 409);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BMI kalkulator";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.webBrowser);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(549, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 426);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Web preglednik ";
            // 
            // BMIkalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AppTeretana.Properties.Resources.Gym;
            this.ClientSize = new System.Drawing.Size(1070, 589);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Name = "BMIkalkulator";
            this.Text = "BMIkalkulator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxBMI;
        private System.Windows.Forms.TextBox txtBoxMasa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxTezina;
        private System.Windows.Forms.Button btnIndeks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}