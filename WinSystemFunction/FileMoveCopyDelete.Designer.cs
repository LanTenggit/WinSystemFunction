namespace WinSystemFunction
{
    partial class FileMoveCopyDelete
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_before = new System.Windows.Forms.TextBox();
            this.tb_after = new System.Windows.Forms.TextBox();
            this.bn_copy = new System.Windows.Forms.Button();
            this.bn_Move = new System.Windows.Forms.Button();
            this.bn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "操作前URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "操作后URL";
            // 
            // tb_before
            // 
            this.tb_before.Location = new System.Drawing.Point(104, 74);
            this.tb_before.Name = "tb_before";
            this.tb_before.Size = new System.Drawing.Size(155, 21);
            this.tb_before.TabIndex = 2;
            // 
            // tb_after
            // 
            this.tb_after.Location = new System.Drawing.Point(104, 126);
            this.tb_after.Name = "tb_after";
            this.tb_after.Size = new System.Drawing.Size(155, 21);
            this.tb_after.TabIndex = 3;
            // 
            // bn_copy
            // 
            this.bn_copy.Location = new System.Drawing.Point(12, 206);
            this.bn_copy.Name = "bn_copy";
            this.bn_copy.Size = new System.Drawing.Size(75, 23);
            this.bn_copy.TabIndex = 4;
            this.bn_copy.Text = "复制";
            this.bn_copy.UseVisualStyleBackColor = true;
            this.bn_copy.Click += new System.EventHandler(this.bn_copy_Click);
            // 
            // bn_Move
            // 
            this.bn_Move.Location = new System.Drawing.Point(104, 206);
            this.bn_Move.Name = "bn_Move";
            this.bn_Move.Size = new System.Drawing.Size(75, 23);
            this.bn_Move.TabIndex = 5;
            this.bn_Move.Text = "移动";
            this.bn_Move.UseVisualStyleBackColor = true;
            this.bn_Move.Click += new System.EventHandler(this.bn_Move_Click);
            // 
            // bn_delete
            // 
            this.bn_delete.Location = new System.Drawing.Point(197, 206);
            this.bn_delete.Name = "bn_delete";
            this.bn_delete.Size = new System.Drawing.Size(75, 23);
            this.bn_delete.TabIndex = 6;
            this.bn_delete.Text = "删除";
            this.bn_delete.UseVisualStyleBackColor = true;
            this.bn_delete.Click += new System.EventHandler(this.bn_delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "复制整个文件夹";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(197, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "主页面";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FileMoveCopyDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 318);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bn_delete);
            this.Controls.Add(this.bn_Move);
            this.Controls.Add(this.bn_copy);
            this.Controls.Add(this.tb_after);
            this.Controls.Add(this.tb_before);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FileMoveCopyDelete";
            this.Text = "FileMoveCopyDelete";
            this.Load += new System.EventHandler(this.FileMoveCopyDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_before;
        private System.Windows.Forms.TextBox tb_after;
        private System.Windows.Forms.Button bn_copy;
        private System.Windows.Forms.Button bn_Move;
        private System.Windows.Forms.Button bn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}