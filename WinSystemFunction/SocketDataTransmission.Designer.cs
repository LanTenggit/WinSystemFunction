namespace WinSystemFunction
{
    partial class SocketDataTransmission
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
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.tb_Prot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bn_listen = new System.Windows.Forms.Button();
            this.bn_stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.TextBox();
            this.tb_sendtxt = new System.Windows.Forms.TextBox();
            this.bn_send = new System.Windows.Forms.Button();
            this.bn_check = new System.Windows.Forms.Button();
            this.bn_SendFile = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // tb_ip
            // 
            this.tb_ip.Location = new System.Drawing.Point(58, 37);
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.Size = new System.Drawing.Size(195, 21);
            this.tb_ip.TabIndex = 1;
            // 
            // tb_Prot
            // 
            this.tb_Prot.Location = new System.Drawing.Point(325, 37);
            this.tb_Prot.Name = "tb_Prot";
            this.tb_Prot.Size = new System.Drawing.Size(75, 21);
            this.tb_Prot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prot";
            // 
            // bn_listen
            // 
            this.bn_listen.Location = new System.Drawing.Point(325, 90);
            this.bn_listen.Name = "bn_listen";
            this.bn_listen.Size = new System.Drawing.Size(72, 23);
            this.bn_listen.TabIndex = 4;
            this.bn_listen.Text = "监听";
            this.bn_listen.UseVisualStyleBackColor = true;
            this.bn_listen.Click += new System.EventHandler(this.bn_listen_Click);
            // 
            // bn_stop
            // 
            this.bn_stop.Location = new System.Drawing.Point(325, 134);
            this.bn_stop.Name = "bn_stop";
            this.bn_stop.Size = new System.Drawing.Size(71, 23);
            this.bn_stop.TabIndex = 5;
            this.bn_stop.Text = "停止";
            this.bn_stop.UseVisualStyleBackColor = true;
            this.bn_stop.Click += new System.EventHandler(this.bn_stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Location = new System.Drawing.Point(26, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 302);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MessageList";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 26);
            this.richTextBox2.Multiline = true;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(311, 270);
            this.richTextBox2.TabIndex = 0;
            // 
            // tb_sendtxt
            // 
            this.tb_sendtxt.Location = new System.Drawing.Point(31, 471);
            this.tb_sendtxt.Name = "tb_sendtxt";
            this.tb_sendtxt.Size = new System.Drawing.Size(337, 21);
            this.tb_sendtxt.TabIndex = 7;
            // 
            // bn_send
            // 
            this.bn_send.Location = new System.Drawing.Point(374, 469);
            this.bn_send.Name = "bn_send";
            this.bn_send.Size = new System.Drawing.Size(75, 23);
            this.bn_send.TabIndex = 8;
            this.bn_send.Text = "发送";
            this.bn_send.UseVisualStyleBackColor = true;
            this.bn_send.Click += new System.EventHandler(this.bn_send_Click);
            // 
            // bn_check
            // 
            this.bn_check.Location = new System.Drawing.Point(520, 471);
            this.bn_check.Name = "bn_check";
            this.bn_check.Size = new System.Drawing.Size(75, 23);
            this.bn_check.TabIndex = 9;
            this.bn_check.Text = "选择文件";
            this.bn_check.UseVisualStyleBackColor = true;
            this.bn_check.Click += new System.EventHandler(this.bn_check_Click);
            // 
            // bn_SendFile
            // 
            this.bn_SendFile.Location = new System.Drawing.Point(601, 471);
            this.bn_SendFile.Name = "bn_SendFile";
            this.bn_SendFile.Size = new System.Drawing.Size(75, 23);
            this.bn_SendFile.TabIndex = 10;
            this.bn_SendFile.Text = "发送";
            this.bn_SendFile.UseVisualStyleBackColor = true;
            this.bn_SendFile.Click += new System.EventHandler(this.bn_SendFile_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(339, 26);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(311, 270);
            this.richTextBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(437, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 124);
            this.listBox1.TabIndex = 11;
            // 
            // SocketDataTransmission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 518);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bn_SendFile);
            this.Controls.Add(this.bn_check);
            this.Controls.Add(this.bn_send);
            this.Controls.Add(this.tb_sendtxt);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bn_stop);
            this.Controls.Add(this.bn_listen);
            this.Controls.Add(this.tb_Prot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.label1);
            this.Name = "SocketDataTransmission";
            this.Text = "SocketDataTransmission";
            this.Load += new System.EventHandler(this.SocketDataTransmission_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.TextBox tb_Prot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bn_listen;
        private System.Windows.Forms.Button bn_stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox richTextBox2;
        private System.Windows.Forms.TextBox tb_sendtxt;
        private System.Windows.Forms.Button bn_send;
        private System.Windows.Forms.Button bn_check;
        private System.Windows.Forms.Button bn_SendFile;
        private System.Windows.Forms.TextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}