namespace test1
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.keybutton = new System.Windows.Forms.Button();
            this.pBox = new System.Windows.Forms.TextBox();
            this.qBox = new System.Windows.Forms.TextBox();
            this.plainBox = new System.Windows.Forms.TextBox();
            this.cipherBox = new System.Windows.Forms.TextBox();
            this.enbutton = new System.Windows.Forms.Button();
            this.debutton = new System.Windows.Forms.Button();
            this.quitbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.enkeyBox = new System.Windows.Forms.TextBox();
            this.dekeyBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.nBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.saveBox = new System.Windows.Forms.TextBox();
            this.pinbutton = new System.Windows.Forms.Button();
            this.cinbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // keybutton
            // 
            this.keybutton.BackColor = System.Drawing.Color.Transparent;
            this.keybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keybutton.Location = new System.Drawing.Point(108, 210);
            this.keybutton.Name = "keybutton";
            this.keybutton.Size = new System.Drawing.Size(85, 37);
            this.keybutton.TabIndex = 0;
            this.keybutton.Text = "密钥生成";
            this.keybutton.UseVisualStyleBackColor = false;
            this.keybutton.Click += new System.EventHandler(this.keybutton_Click);
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(108, 26);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(100, 21);
            this.pBox.TabIndex = 1;
            // 
            // qBox
            // 
            this.qBox.Location = new System.Drawing.Point(108, 58);
            this.qBox.Name = "qBox";
            this.qBox.Size = new System.Drawing.Size(100, 21);
            this.qBox.TabIndex = 2;
            // 
            // plainBox
            // 
            this.plainBox.Location = new System.Drawing.Point(285, 27);
            this.plainBox.Multiline = true;
            this.plainBox.Name = "plainBox";
            this.plainBox.Size = new System.Drawing.Size(256, 47);
            this.plainBox.TabIndex = 3;
            // 
            // cipherBox
            // 
            this.cipherBox.Location = new System.Drawing.Point(285, 98);
            this.cipherBox.Multiline = true;
            this.cipherBox.Name = "cipherBox";
            this.cipherBox.Size = new System.Drawing.Size(256, 49);
            this.cipherBox.TabIndex = 4;
            // 
            // enbutton
            // 
            this.enbutton.BackColor = System.Drawing.Color.Transparent;
            this.enbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enbutton.Location = new System.Drawing.Point(285, 278);
            this.enbutton.Name = "enbutton";
            this.enbutton.Size = new System.Drawing.Size(75, 23);
            this.enbutton.TabIndex = 5;
            this.enbutton.Text = "加密";
            this.enbutton.UseVisualStyleBackColor = false;
            this.enbutton.Click += new System.EventHandler(this.enbutton_Click);
            // 
            // debutton
            // 
            this.debutton.BackColor = System.Drawing.Color.Transparent;
            this.debutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.debutton.Location = new System.Drawing.Point(388, 278);
            this.debutton.Name = "debutton";
            this.debutton.Size = new System.Drawing.Size(75, 23);
            this.debutton.TabIndex = 6;
            this.debutton.Text = "解密";
            this.debutton.UseVisualStyleBackColor = false;
            this.debutton.Click += new System.EventHandler(this.debutton_Click);
            // 
            // quitbutton
            // 
            this.quitbutton.BackColor = System.Drawing.Color.Transparent;
            this.quitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitbutton.Location = new System.Drawing.Point(584, 320);
            this.quitbutton.Name = "quitbutton";
            this.quitbutton.Size = new System.Drawing.Size(52, 23);
            this.quitbutton.TabIndex = 7;
            this.quitbutton.Text = "退出";
            this.quitbutton.UseVisualStyleBackColor = false;
            this.quitbutton.Click += new System.EventHandler(this.quitbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(80, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "p";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(80, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(244, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "密文";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(244, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "明文";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(38, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "加密密钥";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "解密密钥";
            // 
            // enkeyBox
            // 
            this.enkeyBox.Location = new System.Drawing.Point(108, 137);
            this.enkeyBox.Name = "enkeyBox";
            this.enkeyBox.Size = new System.Drawing.Size(100, 21);
            this.enkeyBox.TabIndex = 14;
            // 
            // dekeyBox
            // 
            this.dekeyBox.Location = new System.Drawing.Point(108, 173);
            this.dekeyBox.Name = "dekeyBox";
            this.dekeyBox.Size = new System.Drawing.Size(100, 21);
            this.dekeyBox.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(820, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(779, 173);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 17;
            // 
            // nBox
            // 
            this.nBox.Location = new System.Drawing.Point(108, 97);
            this.nBox.Name = "nBox";
            this.nBox.Size = new System.Drawing.Size(100, 21);
            this.nBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(80, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "n";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(285, 163);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(256, 49);
            this.resultBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(244, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "结果";
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.Transparent;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Location = new System.Drawing.Point(490, 278);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 22;
            this.savebutton.Text = "保存";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(230, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 14);
            this.label9.TabIndex = 23;
            this.label9.Text = "保存到";
            // 
            // saveBox
            // 
            this.saveBox.Location = new System.Drawing.Point(285, 223);
            this.saveBox.Multiline = true;
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(256, 49);
            this.saveBox.TabIndex = 24;
            // 
            // pinbutton
            // 
            this.pinbutton.BackColor = System.Drawing.Color.Transparent;
            this.pinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinbutton.Location = new System.Drawing.Point(551, 40);
            this.pinbutton.Name = "pinbutton";
            this.pinbutton.Size = new System.Drawing.Size(75, 23);
            this.pinbutton.TabIndex = 25;
            this.pinbutton.Text = "导入明文";
            this.pinbutton.UseVisualStyleBackColor = false;
            this.pinbutton.Click += new System.EventHandler(this.pinbutton_Click);
            // 
            // cinbutton
            // 
            this.cinbutton.BackColor = System.Drawing.Color.Transparent;
            this.cinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cinbutton.Location = new System.Drawing.Point(551, 114);
            this.cinbutton.Name = "cinbutton";
            this.cinbutton.Size = new System.Drawing.Size(75, 23);
            this.cinbutton.TabIndex = 26;
            this.cinbutton.Text = "导入密文";
            this.cinbutton.UseVisualStyleBackColor = false;
            this.cinbutton.Click += new System.EventHandler(this.cinbutton_Click);
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(638, 340);
            this.Controls.Add(this.cinbutton);
            this.Controls.Add(this.pinbutton);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dekeyBox);
            this.Controls.Add(this.enkeyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitbutton);
            this.Controls.Add(this.debutton);
            this.Controls.Add(this.enbutton);
            this.Controls.Add(this.cipherBox);
            this.Controls.Add(this.plainBox);
            this.Controls.Add(this.qBox);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.keybutton);
            this.Name = "MainForm2";
            this.Text = "MainForm2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keybutton;
        private System.Windows.Forms.TextBox pBox;
        private System.Windows.Forms.TextBox qBox;
        private System.Windows.Forms.TextBox plainBox;
        private System.Windows.Forms.TextBox cipherBox;
        private System.Windows.Forms.Button enbutton;
        private System.Windows.Forms.Button debutton;
        private System.Windows.Forms.Button quitbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox enkeyBox;
        private System.Windows.Forms.TextBox dekeyBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox nBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox saveBox;
        private System.Windows.Forms.Button pinbutton;
        private System.Windows.Forms.Button cinbutton;
    }
}