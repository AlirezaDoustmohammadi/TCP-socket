namespace client1
{
    partial class TCP_Client_4
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
            this.bt_con = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.bt_stop = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.sen = new System.Windows.Forms.RadioButton();
            this.Req = new System.Windows.Forms.RadioButton();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_con
            // 
            this.bt_con.Location = new System.Drawing.Point(609, 77);
            this.bt_con.Name = "bt_con";
            this.bt_con.Size = new System.Drawing.Size(75, 23);
            this.bt_con.TabIndex = 0;
            this.bt_con.Text = "اتصال";
            this.bt_con.UseVisualStyleBackColor = true;
            this.bt_con.Click += new System.EventHandler(this.bt_con_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(584, 22);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.Text = "127.0.0.2";
            this.txt_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(584, 51);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 2;
            this.txt_port.Text = "5050";
            this.txt_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_port.TextChanged += new System.EventHandler(this.txt_port_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(22, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 134);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // bt_stop
            // 
            this.bt_stop.Location = new System.Drawing.Point(609, 282);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(75, 23);
            this.bt_stop.TabIndex = 6;
            this.bt_stop.Text = "خروج";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(22, 75);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(296, 20);
            this.txt_msg.TabIndex = 4;
            this.txt_msg.TextChanged += new System.EventHandler(this.txt_msg_TextChanged);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(22, 110);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(296, 23);
            this.bt_send.TabIndex = 5;
            this.bt_send.Text = "ارسال";
            this.bt_send.UseVisualStyleBackColor = true;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // sen
            // 
            this.sen.AutoSize = true;
            this.sen.Location = new System.Drawing.Point(233, 25);
            this.sen.Name = "sen";
            this.sen.Size = new System.Drawing.Size(77, 17);
            this.sen.TabIndex = 7;
            this.sen.TabStop = true;
            this.sen.Text = "ارسال فایل";
            this.sen.UseVisualStyleBackColor = true;
            // 
            // Req
            // 
            this.Req.AutoSize = true;
            this.Req.Location = new System.Drawing.Point(22, 25);
            this.Req.Name = "Req";
            this.Req.Size = new System.Drawing.Size(92, 17);
            this.Req.TabIndex = 8;
            this.Req.TabStop = true;
            this.Req.Text = "درخواست فایل";
            this.Req.UseVisualStyleBackColor = true;
            this.Req.CheckedChanged += new System.EventHandler(this.Req_CheckedChanged);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(391, 129);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(250, 20);
            this.txt_path.TabIndex = 10;
            this.txt_path.Text = "FileName:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TCP_Client_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 317);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Req);
            this.Controls.Add(this.sen);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.bt_con);
            this.Name = "TCP_Client_4";
            this.Text = "TCP_Client_4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_con;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.RadioButton sen;
        private System.Windows.Forms.RadioButton Req;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button button1;
    }
}

