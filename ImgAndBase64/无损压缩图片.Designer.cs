namespace WinSystemFunction
{
    partial class 无损压缩图片
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Urlstr = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.tb_bili = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "选择图片";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "压缩";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Urlstr
            // 
            this.Urlstr.AutoSize = true;
            this.Urlstr.Location = new System.Drawing.Point(93, 17);
            this.Urlstr.Name = "Urlstr";
            this.Urlstr.Size = new System.Drawing.Size(41, 12);
            this.Urlstr.TabIndex = 2;
            this.Urlstr.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "高度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "宽度";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "压缩比例";
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(81, 106);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(100, 21);
            this.tb_height.TabIndex = 6;
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(277, 106);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(100, 21);
            this.tb_width.TabIndex = 7;
            // 
            // tb_bili
            // 
            this.tb_bili.Location = new System.Drawing.Point(277, 154);
            this.tb_bili.Name = "tb_bili";
            this.tb_bili.Size = new System.Drawing.Size(100, 21);
            this.tb_bili.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(302, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // 无损压缩图片
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_bili);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Urlstr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "无损压缩图片";
            this.Text = "无损压缩图片";
            this.Load += new System.EventHandler(this.无损压缩图片_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Urlstr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.TextBox tb_bili;
        private System.Windows.Forms.Button button3;
    }
}