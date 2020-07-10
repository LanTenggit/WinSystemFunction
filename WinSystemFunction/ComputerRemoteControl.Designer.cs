namespace WinSystemFunction
{
    partial class ComputerRemoteControl
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
            this.tb_IP = new System.Windows.Forms.TextBox();
            this.tb_MAC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_cancellation = new System.Windows.Forms.Button();
            this.bn_close = new System.Windows.Forms.Button();
            this.bn_restart = new System.Windows.Forms.Button();
            this.bn_task = new System.Windows.Forms.Button();
            this.bn_open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPadress";
            // 
            // tb_IP
            // 
            this.tb_IP.Location = new System.Drawing.Point(83, 32);
            this.tb_IP.Name = "tb_IP";
            this.tb_IP.Size = new System.Drawing.Size(168, 21);
            this.tb_IP.TabIndex = 1;
            // 
            // tb_MAC
            // 
            this.tb_MAC.Location = new System.Drawing.Point(336, 32);
            this.tb_MAC.Name = "tb_MAC";
            this.tb_MAC.Size = new System.Drawing.Size(168, 21);
            this.tb_MAC.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "MACadress";
            // 
            // bn_cancellation
            // 
            this.bn_cancellation.Location = new System.Drawing.Point(125, 143);
            this.bn_cancellation.Name = "bn_cancellation";
            this.bn_cancellation.Size = new System.Drawing.Size(75, 23);
            this.bn_cancellation.TabIndex = 4;
            this.bn_cancellation.Text = "注销";
            this.bn_cancellation.UseVisualStyleBackColor = true;
            this.bn_cancellation.Click += new System.EventHandler(this.bn_cancellation_Click);
            // 
            // bn_close
            // 
            this.bn_close.Location = new System.Drawing.Point(230, 143);
            this.bn_close.Name = "bn_close";
            this.bn_close.Size = new System.Drawing.Size(75, 23);
            this.bn_close.TabIndex = 5;
            this.bn_close.Text = "关机";
            this.bn_close.UseVisualStyleBackColor = true;
            this.bn_close.Click += new System.EventHandler(this.bn_close_Click);
            // 
            // bn_restart
            // 
            this.bn_restart.Location = new System.Drawing.Point(336, 143);
            this.bn_restart.Name = "bn_restart";
            this.bn_restart.Size = new System.Drawing.Size(75, 23);
            this.bn_restart.TabIndex = 6;
            this.bn_restart.Text = "重启";
            this.bn_restart.UseVisualStyleBackColor = true;
            this.bn_restart.Click += new System.EventHandler(this.bn_restart_Click);
            // 
            // bn_task
            // 
            this.bn_task.Location = new System.Drawing.Point(26, 143);
            this.bn_task.Name = "bn_task";
            this.bn_task.Size = new System.Drawing.Size(75, 23);
            this.bn_task.TabIndex = 7;
            this.bn_task.Text = "Tasklist";
            this.bn_task.UseVisualStyleBackColor = true;
            this.bn_task.Click += new System.EventHandler(this.bn_task_Click);
            // 
            // bn_open
            // 
            this.bn_open.Location = new System.Drawing.Point(438, 143);
            this.bn_open.Name = "bn_open";
            this.bn_open.Size = new System.Drawing.Size(75, 23);
            this.bn_open.TabIndex = 8;
            this.bn_open.Text = "开机";
            this.bn_open.UseVisualStyleBackColor = true;
            this.bn_open.Click += new System.EventHandler(this.bn_open_Click);
            // 
            // ComputerRemoteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 282);
            this.Controls.Add(this.bn_open);
            this.Controls.Add(this.bn_task);
            this.Controls.Add(this.bn_restart);
            this.Controls.Add(this.bn_close);
            this.Controls.Add(this.bn_cancellation);
            this.Controls.Add(this.tb_MAC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_IP);
            this.Controls.Add(this.label1);
            this.Name = "ComputerRemoteControl";
            this.Text = "ComputerRemoteControl";
            this.Load += new System.EventHandler(this.ComputerRemoteControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IP;
        private System.Windows.Forms.TextBox tb_MAC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_cancellation;
        private System.Windows.Forms.Button bn_close;
        private System.Windows.Forms.Button bn_restart;
        private System.Windows.Forms.Button bn_task;
        private System.Windows.Forms.Button bn_open;
    }
}