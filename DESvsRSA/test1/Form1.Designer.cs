namespace test1
{
    partial class EntryForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.label1 = new System.Windows.Forms.Label();
            this.EntryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.rsabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("幼圆", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.label1.Location = new System.Drawing.Point(142, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "DES/RSA加密与解密";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EntryButton
            // 
            this.EntryButton.BackColor = System.Drawing.Color.Transparent;
            this.EntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntryButton.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EntryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.EntryButton.Location = new System.Drawing.Point(176, 147);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(97, 48);
            this.EntryButton.TabIndex = 1;
            this.EntryButton.Text = "DES";
            this.EntryButton.UseVisualStyleBackColor = false;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ExitButton.Location = new System.Drawing.Point(382, 271);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(97, 48);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "退出";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // rsabutton
            // 
            this.rsabutton.BackColor = System.Drawing.Color.Transparent;
            this.rsabutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rsabutton.Font = new System.Drawing.Font("华文仿宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rsabutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rsabutton.Location = new System.Drawing.Point(339, 147);
            this.rsabutton.Name = "rsabutton";
            this.rsabutton.Size = new System.Drawing.Size(97, 48);
            this.rsabutton.TabIndex = 3;
            this.rsabutton.Text = "RSA";
            this.rsabutton.UseVisualStyleBackColor = false;
            this.rsabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 320);
            this.Controls.Add(this.rsabutton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "DES";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button rsabutton;
    }
}

