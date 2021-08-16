namespace IR_Remote
{
    partial class Form1
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
            this.btn_startLearn = new System.Windows.Forms.Button();
            this.cmb_sPort = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lbl_toolStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_cls = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_startLearn
            // 
            this.btn_startLearn.Enabled = false;
            this.btn_startLearn.Location = new System.Drawing.Point(238, 70);
            this.btn_startLearn.Name = "btn_startLearn";
            this.btn_startLearn.Size = new System.Drawing.Size(75, 23);
            this.btn_startLearn.TabIndex = 0;
            this.btn_startLearn.Text = "Fetch IR";
            this.btn_startLearn.UseVisualStyleBackColor = true;
            this.btn_startLearn.Click += new System.EventHandler(this.btn_startLearn_Click);
            // 
            // cmb_sPort
            // 
            this.cmb_sPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_sPort.FormattingEnabled = true;
            this.cmb_sPort.Location = new System.Drawing.Point(12, 12);
            this.cmb_sPort.Name = "cmb_sPort";
            this.cmb_sPort.Size = new System.Drawing.Size(198, 21);
            this.cmb_sPort.TabIndex = 1;
            this.cmb_sPort.DropDown += new System.EventHandler(this.cmb_sPort_DropDown);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(238, 12);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_toolStrip});
            this.statusStrip.Location = new System.Drawing.Point(0, 502);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(531, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // lbl_toolStrip
            // 
            this.lbl_toolStrip.Name = "lbl_toolStrip";
            this.lbl_toolStrip.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_cls
            // 
            this.btn_cls.Location = new System.Drawing.Point(238, 41);
            this.btn_cls.Name = "btn_cls";
            this.btn_cls.Size = new System.Drawing.Size(75, 23);
            this.btn_cls.TabIndex = 4;
            this.btn_cls.Text = "Clear cache";
            this.btn_cls.UseVisualStyleBackColor = true;
            this.btn_cls.Click += new System.EventHandler(this.btn_cls_Click);
            // 
            // btn_send
            // 
            this.btn_send.Enabled = false;
            this.btn_send.Location = new System.Drawing.Point(238, 99);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send IR";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 128);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(507, 357);
            this.textBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 524);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_cls);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cmb_sPort);
            this.Controls.Add(this.btn_startLearn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_startLearn;
        private System.Windows.Forms.ComboBox cmb_sPort;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lbl_toolStrip;
        private System.Windows.Forms.Button btn_cls;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox textBox;
    }
}

