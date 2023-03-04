namespace CN_Assignment_1
{
    partial class ServerWindow
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
            this.IncomingLabel = new System.Windows.Forms.Label();
            this.OutgoingTextBox = new System.Windows.Forms.TextBox();
            this.OutgoingLabel = new System.Windows.Forms.Label();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ListenBtn = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IncomingLabel
            // 
            this.IncomingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingLabel.ForeColor = System.Drawing.Color.White;
            this.IncomingLabel.Location = new System.Drawing.Point(2, 144);
            this.IncomingLabel.Name = "IncomingLabel";
            this.IncomingLabel.Size = new System.Drawing.Size(153, 28);
            this.IncomingLabel.TabIndex = 4;
            this.IncomingLabel.Text = "Your Conversation:";
            // 
            // OutgoingTextBox
            // 
            this.OutgoingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.OutgoingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutgoingTextBox.ForeColor = System.Drawing.Color.White;
            this.OutgoingTextBox.Location = new System.Drawing.Point(9, 401);
            this.OutgoingTextBox.Multiline = true;
            this.OutgoingTextBox.Name = "OutgoingTextBox";
            this.OutgoingTextBox.Size = new System.Drawing.Size(773, 178);
            this.OutgoingTextBox.TabIndex = 5;
            // 
            // OutgoingLabel
            // 
            this.OutgoingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutgoingLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OutgoingLabel.Location = new System.Drawing.Point(8, 370);
            this.OutgoingLabel.Name = "OutgoingLabel";
            this.OutgoingLabel.Size = new System.Drawing.Size(165, 28);
            this.OutgoingLabel.TabIndex = 6;
            this.OutgoingLabel.Text = "Enter your message:";
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(796, 440);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(96, 94);
            this.SendBtn.TabIndex = 7;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ListenBtn
            // 
            this.ListenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ListenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenBtn.ForeColor = System.Drawing.Color.White;
            this.ListenBtn.Location = new System.Drawing.Point(274, 47);
            this.ListenBtn.Name = "ListenBtn";
            this.ListenBtn.Size = new System.Drawing.Size(182, 39);
            this.ListenBtn.TabIndex = 18;
            this.ListenBtn.Text = "Start Listening";
            this.ListenBtn.UseVisualStyleBackColor = false;
            this.ListenBtn.Click += new System.EventHandler(this.ListenBtn_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.ConnectionStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(13, 92);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(229, 28);
            this.ConnectionStatusLabel.TabIndex = 17;
            this.ConnectionStatusLabel.Text = "Not Connected";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortTextBox
            // 
            this.PortTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.PortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortTextBox.ForeColor = System.Drawing.Color.White;
            this.PortTextBox.Location = new System.Drawing.Point(16, 47);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(226, 26);
            this.PortTextBox.TabIndex = 16;
            this.PortTextBox.Text = "1234";
            this.PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PortTextBox_KeyPress);
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.IPLabel.Location = new System.Drawing.Point(12, 16);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(242, 28);
            this.IPLabel.TabIndex = 15;
            this.IPLabel.Text = "Enter Host Port:";
            // 
            // MessageListBox
            // 
            this.MessageListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.MessageListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageListBox.ForeColor = System.Drawing.Color.White;
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.ItemHeight = 19;
            this.MessageListBox.Location = new System.Drawing.Point(9, 172);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageListBox.Size = new System.Drawing.Size(883, 175);
            this.MessageListBox.TabIndex = 19;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.DisconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.ForeColor = System.Drawing.Color.White;
            this.DisconnectBtn.Location = new System.Drawing.Point(274, 93);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(182, 39);
            this.DisconnectBtn.TabIndex = 22;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = false;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(523, 74);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(350, 45);
            this.TitleLabel.TabIndex = 23;
            this.TitleLabel.Text = "Chat Messenger";
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.ForeColor = System.Drawing.Color.White;
            this.TitleLabel2.Location = new System.Drawing.Point(628, 28);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(119, 45);
            this.TitleLabel2.TabIndex = 24;
            this.TitleLabel2.Text = "CN-1";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerLabel.ForeColor = System.Drawing.Color.White;
            this.OwnerLabel.Location = new System.Drawing.Point(670, 121);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(202, 23);
            this.OwnerLabel.TabIndex = 25;
            this.OwnerLabel.Text = "Property of Ayaan and Rayyan";
            // 
            // ServerWindow
            // 
            this.AcceptButton = this.SendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(904, 609);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.TitleLabel2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.ListenBtn);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.OutgoingLabel);
            this.Controls.Add(this.OutgoingTextBox);
            this.Controls.Add(this.IncomingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "ServerWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server - Chat Messenger";
            this.Shown += new System.EventHandler(this.ServerWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IncomingLabel;
        private System.Windows.Forms.TextBox OutgoingTextBox;
        private System.Windows.Forms.Label OutgoingLabel;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button ListenBtn;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Label OwnerLabel;
    }
}

