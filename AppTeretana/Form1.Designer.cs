namespace AppTeretana
{
    partial class Form1
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
            this.btnClanstvo = new System.Windows.Forms.Button();
            this.btnBMIkalkulator = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(352, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobrodošli!!!";
            // 
            // btnClanstvo
            // 
            this.btnClanstvo.BackColor = System.Drawing.Color.OliveDrab;
            this.btnClanstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnClanstvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClanstvo.Location = new System.Drawing.Point(66, 263);
            this.btnClanstvo.Name = "btnClanstvo";
            this.btnClanstvo.Size = new System.Drawing.Size(277, 87);
            this.btnClanstvo.TabIndex = 2;
            this.btnClanstvo.Text = "Clanstvo";
            this.btnClanstvo.UseVisualStyleBackColor = false;
            this.btnClanstvo.Click += new System.EventHandler(this.btnClanstvo_Click);
            // 
            // btnBMIkalkulator
            // 
            this.btnBMIkalkulator.BackColor = System.Drawing.Color.OliveDrab;
            this.btnBMIkalkulator.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.btnBMIkalkulator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnBMIkalkulator.Location = new System.Drawing.Point(648, 279);
            this.btnBMIkalkulator.Name = "btnBMIkalkulator";
            this.btnBMIkalkulator.Size = new System.Drawing.Size(324, 71);
            this.btnBMIkalkulator.TabIndex = 3;
            this.btnBMIkalkulator.Text = "BMI KALKULATOR";
            this.btnBMIkalkulator.UseVisualStyleBackColor = false;
            this.btnBMIkalkulator.Click += new System.EventHandler(this.btnBMIkalkulator_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.OliveDrab;
            this.label2.Location = new System.Drawing.Point(12, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kilkom na ovaj gumb se možete učlaniti u teretanu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.ForeColor = System.Drawing.Color.OliveDrab;
            this.label3.Location = new System.Drawing.Point(527, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(533, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Klikom na ovaj gumb možete izračunati indeks vaše tjelesne mase";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::AppTeretana.Properties.Resources.Gym;
            this.ClientSize = new System.Drawing.Size(1072, 597);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBMIkalkulator);
            this.Controls.Add(this.btnClanstvo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClanstvo;
        private System.Windows.Forms.Button btnBMIkalkulator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

