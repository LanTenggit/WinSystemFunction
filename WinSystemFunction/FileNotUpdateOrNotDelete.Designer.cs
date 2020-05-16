namespace WinSystemFunction
{
    partial class FileNotUpdateOrNotDelete
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
            this.tb_src = new System.Windows.Forms.TextBox();
            this.bn_SureProtect = new System.Windows.Forms.Button();
            this.bn_Revoke = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件路径";
            // 
            // tb_src
            // 
            this.tb_src.Location = new System.Drawing.Point(124, 127);
            this.tb_src.Name = "tb_src";
            this.tb_src.Size = new System.Drawing.Size(205, 21);
            this.tb_src.TabIndex = 1;
            // 
            // bn_SureProtect
            // 
            this.bn_SureProtect.Location = new System.Drawing.Point(49, 214);
            this.bn_SureProtect.Name = "bn_SureProtect";
            this.bn_SureProtect.Size = new System.Drawing.Size(75, 23);
            this.bn_SureProtect.TabIndex = 2;
            this.bn_SureProtect.Text = "确认保护";
            this.bn_SureProtect.UseVisualStyleBackColor = true;
            this.bn_SureProtect.Click += new System.EventHandler(this.bn_SureProtect_Click);
            // 
            // bn_Revoke
            // 
            this.bn_Revoke.Location = new System.Drawing.Point(254, 214);
            this.bn_Revoke.Name = "bn_Revoke";
            this.bn_Revoke.Size = new System.Drawing.Size(75, 23);
            this.bn_Revoke.TabIndex = 3;
            this.bn_Revoke.Text = "销毁";
            this.bn_Revoke.UseVisualStyleBackColor = true;
            this.bn_Revoke.Click += new System.EventHandler(this.bn_Revoke_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(98, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "保护文件不被操作";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "文件隐藏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileNotUpdateOrNotDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bn_Revoke);
            this.Controls.Add(this.bn_SureProtect);
            this.Controls.Add(this.tb_src);
            this.Controls.Add(this.label1);
            this.Name = "FileNotUpdateOrNotDelete";
            this.Text = "FileNotUpdateOrNotDelete";
            this.Load += new System.EventHandler(this.FileNotUpdateOrNotDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_src;
        private System.Windows.Forms.Button bn_SureProtect;
        private System.Windows.Forms.Button bn_Revoke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}