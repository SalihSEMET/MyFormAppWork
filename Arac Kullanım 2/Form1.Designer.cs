namespace Arac_Kullanım_2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.surnamelbl = new System.Windows.Forms.Label();
            this.Joblbl = new System.Windows.Forms.Label();
            this.Citylbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox1.Location = new System.Drawing.Point(326, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox3.Location = new System.Drawing.Point(326, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 42);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(326, 169);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 42);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox5.Location = new System.Drawing.Point(326, 121);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 42);
            this.textBox5.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Location = new System.Drawing.Point(220, 77);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(100, 35);
            this.namelbl.TabIndex = 5;
            this.namelbl.Text = "Adınız:";
            // 
            // surnamelbl
            // 
            this.surnamelbl.AutoSize = true;
            this.surnamelbl.Location = new System.Drawing.Point(178, 121);
            this.surnamelbl.Name = "surnamelbl";
            this.surnamelbl.Size = new System.Drawing.Size(142, 35);
            this.surnamelbl.TabIndex = 6;
            this.surnamelbl.Text = "Soyadınız:";
            // 
            // Joblbl
            // 
            this.Joblbl.AutoSize = true;
            this.Joblbl.Location = new System.Drawing.Point(213, 173);
            this.Joblbl.Name = "Joblbl";
            this.Joblbl.Size = new System.Drawing.Size(107, 35);
            this.Joblbl.TabIndex = 7;
            this.Joblbl.Text = "Meslek:";
            // 
            // Citylbl
            // 
            this.Citylbl.AutoSize = true;
            this.Citylbl.Location = new System.Drawing.Point(242, 221);
            this.Citylbl.Name = "Citylbl";
            this.Citylbl.Size = new System.Drawing.Size(78, 35);
            this.Citylbl.TabIndex = 8;
            this.Citylbl.Text = "Şehir";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(479, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "Bilği Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1540, 871);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Citylbl);
            this.Controls.Add(this.Joblbl);
            this.Controls.Add(this.surnamelbl);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Corbel", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label surnamelbl;
        private System.Windows.Forms.Label Joblbl;
        private System.Windows.Forms.Label Citylbl;
        private System.Windows.Forms.Button button1;
    }
}

