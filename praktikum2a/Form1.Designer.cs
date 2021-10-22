
namespace praktikum2a
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
            this.txtbil1 = new System.Windows.Forms.TextBox();
            this.txtbil2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtangka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txthasilnilai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txthasilref = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txthasilout = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BILANGAN 1";
            // 
            // txtbil1
            // 
            this.txtbil1.Location = new System.Drawing.Point(132, 36);
            this.txtbil1.Name = "txtbil1";
            this.txtbil1.Size = new System.Drawing.Size(125, 20);
            this.txtbil1.TabIndex = 1;
            // 
            // txtbil2
            // 
            this.txtbil2.Location = new System.Drawing.Point(132, 62);
            this.txtbil2.Name = "txtbil2";
            this.txtbil2.Size = new System.Drawing.Size(125, 20);
            this.txtbil2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "BILANGAN 2";
            // 
            // txtangka
            // 
            this.txtangka.Location = new System.Drawing.Point(344, 38);
            this.txtangka.Name = "txtangka";
            this.txtangka.Size = new System.Drawing.Size(125, 20);
            this.txtangka.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ANGKA";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(565, 40);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(494, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ANGKA";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "PARAMETER NILAI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 44);
            this.button2.TabIndex = 9;
            this.button2.Text = "PARAMETER REF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 44);
            this.button3.TabIndex = 10;
            this.button3.Text = "PARAMETER OUT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txthasilnilai
            // 
            this.txthasilnilai.Location = new System.Drawing.Point(85, 258);
            this.txthasilnilai.Name = "txthasilnilai";
            this.txthasilnilai.Size = new System.Drawing.Size(125, 20);
            this.txthasilnilai.TabIndex = 12;
            this.txthasilnilai.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "HASIL";
            // 
            // txthasilref
            // 
            this.txthasilref.Location = new System.Drawing.Point(328, 258);
            this.txthasilref.Name = "txthasilref";
            this.txthasilref.Size = new System.Drawing.Size(125, 20);
            this.txthasilref.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "HASIL";
            // 
            // txthasilout
            // 
            this.txthasilout.Location = new System.Drawing.Point(565, 256);
            this.txthasilout.Name = "txthasilout";
            this.txthasilout.Size = new System.Drawing.Size(125, 20);
            this.txthasilout.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(502, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "HASIL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 345);
            this.Controls.Add(this.txthasilout);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txthasilref);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txthasilnilai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtangka);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbil2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbil1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbil1;
        private System.Windows.Forms.TextBox txtbil2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtangka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txthasilnilai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txthasilref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txthasilout;
        private System.Windows.Forms.Label label7;
    }
}

