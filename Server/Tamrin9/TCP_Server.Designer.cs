namespace Tamrin9
{
    partial class TCP_Server
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
            this.bt_co = new System.Windows.Forms.Button();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.bt_exit = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bt_co
            // 
            this.bt_co.Location = new System.Drawing.Point(532, 53);
            this.bt_co.Name = "bt_co";
            this.bt_co.Size = new System.Drawing.Size(75, 23);
            this.bt_co.TabIndex = 0;
            this.bt_co.Text = "اتصال";
            this.bt_co.UseVisualStyleBackColor = true;
            this.bt_co.Click += new System.EventHandler(this.bt_co_Click);
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(423, 102);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 20);
            this.txt_port.TabIndex = 1;
            this.txt_port.Text = "5050";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(423, 28);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 2;
            this.txt_ip.Text = "127.0.0.2";
            this.txt_ip.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bt_exit
            // 
            this.bt_exit.Location = new System.Drawing.Point(532, 226);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(75, 23);
            this.bt_exit.TabIndex = 6;
            this.bt_exit.Text = "خروج";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(48, 129);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(305, 108);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // TCP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.bt_co);
            this.Name = "TCP_Server";
            this.Text = "TCP_Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_co;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.ListBox listBox1;
    }
}

