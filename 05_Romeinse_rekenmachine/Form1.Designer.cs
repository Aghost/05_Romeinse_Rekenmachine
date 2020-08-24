namespace _05_Romeinse_rekenmachine
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_I = new System.Windows.Forms.Button();
            this.btn_v = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_l = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_m = new System.Windows.Forms.Button();
            this.btn_d = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.lbl_calc = new System.Windows.Forms.Label();
            this.lbl_dec = new System.Windows.Forms.Label();
            this.btn_eq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 54);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(547, 78);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_I
            // 
            this.btn_I.Location = new System.Drawing.Point(12, 138);
            this.btn_I.Name = "btn_I";
            this.btn_I.Size = new System.Drawing.Size(73, 36);
            this.btn_I.TabIndex = 2;
            this.btn_I.Text = "I";
            this.btn_I.UseVisualStyleBackColor = true;
            this.btn_I.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_v
            // 
            this.btn_v.Location = new System.Drawing.Point(91, 138);
            this.btn_v.Name = "btn_v";
            this.btn_v.Size = new System.Drawing.Size(73, 36);
            this.btn_v.TabIndex = 3;
            this.btn_v.Text = "V";
            this.btn_v.UseVisualStyleBackColor = true;
            this.btn_v.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_x
            // 
            this.btn_x.Location = new System.Drawing.Point(170, 138);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(73, 36);
            this.btn_x.TabIndex = 4;
            this.btn_x.Text = "X";
            this.btn_x.UseVisualStyleBackColor = true;
            this.btn_x.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_l
            // 
            this.btn_l.Location = new System.Drawing.Point(249, 138);
            this.btn_l.Name = "btn_l";
            this.btn_l.Size = new System.Drawing.Size(73, 36);
            this.btn_l.TabIndex = 5;
            this.btn_l.Text = "L";
            this.btn_l.UseVisualStyleBackColor = true;
            this.btn_l.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(328, 138);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(73, 36);
            this.btn_c.TabIndex = 6;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_m
            // 
            this.btn_m.Location = new System.Drawing.Point(486, 138);
            this.btn_m.Name = "btn_m";
            this.btn_m.Size = new System.Drawing.Size(73, 36);
            this.btn_m.TabIndex = 7;
            this.btn_m.Text = "M";
            this.btn_m.UseVisualStyleBackColor = true;
            this.btn_m.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_d
            // 
            this.btn_d.Location = new System.Drawing.Point(407, 138);
            this.btn_d.Name = "btn_d";
            this.btn_d.Size = new System.Drawing.Size(73, 36);
            this.btn_d.TabIndex = 8;
            this.btn_d.Text = "D";
            this.btn_d.UseVisualStyleBackColor = true;
            this.btn_d.Click += new System.EventHandler(this.Numeral_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(565, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 36);
            this.btn_add.TabIndex = 9;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(565, 54);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(73, 36);
            this.btn_sub.TabIndex = 10;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(565, 96);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(73, 36);
            this.btn_mul.TabIndex = 11;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.Operator_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(565, 138);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(73, 36);
            this.btn_div.TabIndex = 12;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.Operator_Click);
            // 
            // lbl_calc
            // 
            this.lbl_calc.AutoSize = true;
            this.lbl_calc.Location = new System.Drawing.Point(12, 57);
            this.lbl_calc.Name = "lbl_calc";
            this.lbl_calc.Size = new System.Drawing.Size(9, 13);
            this.lbl_calc.TabIndex = 13;
            this.lbl_calc.Text = "|";
            // 
            // lbl_dec
            // 
            this.lbl_dec.AutoSize = true;
            this.lbl_dec.Location = new System.Drawing.Point(12, 177);
            this.lbl_dec.Name = "lbl_dec";
            this.lbl_dec.Size = new System.Drawing.Size(48, 13);
            this.lbl_dec.TabIndex = 14;
            this.lbl_dec.Text = "Decimal:";
            // 
            // btn_eq
            // 
            this.btn_eq.Location = new System.Drawing.Point(488, 202);
            this.btn_eq.Name = "btn_eq";
            this.btn_eq.Size = new System.Drawing.Size(152, 36);
            this.btn_eq.TabIndex = 15;
            this.btn_eq.Text = "=";
            this.btn_eq.UseVisualStyleBackColor = true;
            this.btn_eq.Click += new System.EventHandler(this.btn_eq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 250);
            this.Controls.Add(this.btn_eq);
            this.Controls.Add(this.lbl_dec);
            this.Controls.Add(this.lbl_calc);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_d);
            this.Controls.Add(this.btn_m);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_l);
            this.Controls.Add(this.btn_x);
            this.Controls.Add(this.btn_v);
            this.Controls.Add(this.btn_I);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Calculator Romanus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_I;
        private System.Windows.Forms.Button btn_v;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_l;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_m;
        private System.Windows.Forms.Button btn_d;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Label lbl_calc;
        private System.Windows.Forms.Label lbl_dec;
        private System.Windows.Forms.Button btn_eq;
    }
}

