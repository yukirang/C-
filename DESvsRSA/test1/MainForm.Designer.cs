namespace test1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.enButton = new System.Windows.Forms.Button();
            this.deButton = new System.Windows.Forms.Button();
            this.plainBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cipherBox = new System.Windows.Forms.TextBox();
            this.exButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.saveBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enButton
            // 
            this.enButton.BackColor = System.Drawing.Color.Transparent;
            this.enButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.enButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enButton.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.enButton.ForeColor = System.Drawing.Color.Transparent;
            this.enButton.Location = new System.Drawing.Point(447, 122);
            this.enButton.Name = "enButton";
            this.enButton.Size = new System.Drawing.Size(75, 23);
            this.enButton.TabIndex = 0;
            this.enButton.Text = "加密";
            this.enButton.UseVisualStyleBackColor = false;
            this.enButton.Click += new System.EventHandler(this.EnButton_Click);
            // 
            // deButton
            // 
            this.deButton.BackColor = System.Drawing.Color.Transparent;
            this.deButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deButton.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.deButton.ForeColor = System.Drawing.Color.White;
            this.deButton.Location = new System.Drawing.Point(447, 192);
            this.deButton.Name = "deButton";
            this.deButton.Size = new System.Drawing.Size(75, 23);
            this.deButton.TabIndex = 1;
            this.deButton.Text = "解密";
            this.deButton.UseVisualStyleBackColor = false;
            this.deButton.Click += new System.EventHandler(this.deButton_Click);
            // 
            // plainBox
            // 
            this.plainBox.Location = new System.Drawing.Point(159, 94);
            this.plainBox.Multiline = true;
            this.plainBox.Name = "plainBox";
            this.plainBox.Size = new System.Drawing.Size(263, 50);
            this.plainBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "   明文：";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(75, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "   密文：";
            // 
            // cipherBox
            // 
            this.cipherBox.Location = new System.Drawing.Point(159, 165);
            this.cipherBox.Multiline = true;
            this.cipherBox.Name = "cipherBox";
            this.cipherBox.Size = new System.Drawing.Size(263, 50);
            this.cipherBox.TabIndex = 5;
            // 
            // exButton
            // 
            this.exButton.BackColor = System.Drawing.Color.Transparent;
            this.exButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.exButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exButton.Font = new System.Drawing.Font("华文仿宋", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exButton.Location = new System.Drawing.Point(499, 323);
            this.exButton.Name = "exButton";
            this.exButton.Size = new System.Drawing.Size(82, 45);
            this.exButton.TabIndex = 6;
            this.exButton.Text = "退出";
            this.exButton.UseVisualStyleBackColor = false;
            this.exButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(75, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "   密钥：";
            // 
            // keyBox
            // 
            this.keyBox.Location = new System.Drawing.Point(159, 22);
            this.keyBox.Multiline = true;
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(263, 50);
            this.keyBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(101, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "结果：";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(159, 235);
            this.resultBox.Multiline = true;
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(263, 50);
            this.resultBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(447, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "导入明文";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(447, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "导入密文";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(447, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "导出结果";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(101, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "保存到：";
            // 
            // saveBox
            // 
            this.saveBox.Location = new System.Drawing.Point(159, 300);
            this.saveBox.Multiline = true;
            this.saveBox.Name = "saveBox";
            this.saveBox.Size = new System.Drawing.Size(263, 41);
            this.saveBox.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(582, 368);
            this.Controls.Add(this.saveBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exButton);
            this.Controls.Add(this.cipherBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainBox);
            this.Controls.Add(this.deButton);
            this.Controls.Add(this.enButton);
            this.Name = "MainForm";
            this.Text = "DES";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enButton;
        private System.Windows.Forms.Button deButton;
        private System.Windows.Forms.TextBox plainBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyBox;
        private System.Windows.Forms.TextBox cipherBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saveBox;
    }
}