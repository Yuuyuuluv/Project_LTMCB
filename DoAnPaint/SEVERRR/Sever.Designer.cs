namespace SEVERRR
{
    partial class Sever
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.txbMembers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleGreen;
            this.label1.Location = new System.Drawing.Point(212, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vẽ Chung";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.pic.Enabled = false;
            this.pic.Location = new System.Drawing.Point(9, 70);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(640, 560);
            this.pic.TabIndex = 4;
            this.pic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.PaleGreen;
            this.label3.Location = new System.Drawing.Point(648, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(440, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quản Lí Kết Nối Và Trò Chuyện";
            // 
            // txbMessage
            // 
            this.txbMessage.Enabled = false;
            this.txbMessage.Location = new System.Drawing.Point(654, 70);
            this.txbMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(462, 560);
            this.txbMessage.TabIndex = 6;
            // 
            // txbMembers
            // 
            this.txbMembers.Enabled = false;
            this.txbMembers.Location = new System.Drawing.Point(1121, 70);
            this.txbMembers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMembers.Multiline = true;
            this.txbMembers.Name = "txbMembers";
            this.txbMembers.Size = new System.Drawing.Size(189, 560);
            this.txbMembers.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.PaleGreen;
            this.label2.Location = new System.Drawing.Point(1130, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thành Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Sever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SEVERRR.Properties.Resources.download__2_;
            this.ClientSize = new System.Drawing.Size(1321, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMembers);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label1);
            this.Name = "Sever";
            this.Text = "Sever";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sever_FormClosed);
            this.Load += new System.EventHandler(this.Sever_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMessage;
        private System.Windows.Forms.TextBox txbMembers;
        private System.Windows.Forms.Label label2;
    }
}

