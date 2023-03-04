namespace CN_Assignment_1___Client
{
    partial class ClientWindow
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
            this.SendBtn = new System.Windows.Forms.Button();
            this.OutgoingLabel = new System.Windows.Forms.Label();
            this.OutgoingTextBox = new System.Windows.Forms.TextBox();
            this.IncomingLabel = new System.Windows.Forms.Label();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.ConnectionStatusLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.IPLabel = new System.Windows.Forms.Label();
            this.MessageListBox = new System.Windows.Forms.ListBox();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.TitleLabel2 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.OwnerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendBtn
            // 
            this.SendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.SendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendBtn.ForeColor = System.Drawing.Color.White;
            this.SendBtn.Location = new System.Drawing.Point(792, 447);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(103, 94);
            this.SendBtn.TabIndex = 19;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = false;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // OutgoingLabel
            // 
            this.OutgoingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutgoingLabel.ForeColor = System.Drawing.Color.White;
            this.OutgoingLabel.Location = new System.Drawing.Point(6, 377);
            this.OutgoingLabel.Name = "OutgoingLabel";
            this.OutgoingLabel.Size = new System.Drawing.Size(165, 28);
            this.OutgoingLabel.TabIndex = 18;
            this.OutgoingLabel.Text = "Enter your message:";
            // 
            // OutgoingTextBox
            // 
            this.OutgoingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.OutgoingTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutgoingTextBox.ForeColor = System.Drawing.Color.White;
            this.OutgoingTextBox.Location = new System.Drawing.Point(10, 408);
            this.OutgoingTextBox.Multiline = true;
            this.OutgoingTextBox.Name = "OutgoingTextBox";
            this.OutgoingTextBox.Size = new System.Drawing.Size(773, 178);
            this.OutgoingTextBox.TabIndex = 17;
            // 
            // IncomingLabel
            // 
            this.IncomingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncomingLabel.ForeColor = System.Drawing.Color.White;
            this.IncomingLabel.Location = new System.Drawing.Point(6, 134);
            this.IncomingLabel.Name = "IncomingLabel";
            this.IncomingLabel.Size = new System.Drawing.Size(153, 28);
            this.IncomingLabel.TabIndex = 16;
            this.IncomingLabel.Text = "Your Conversation:";
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.ConnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectBtn.ForeColor = System.Drawing.Color.White;
            this.ConnectBtn.Location = new System.Drawing.Point(272, 37);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(182, 39);
            this.ConnectBtn.TabIndex = 14;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = false;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // ConnectionStatusLabel
            // 
            this.ConnectionStatusLabel.BackColor = System.Drawing.SystemColors.Desktop;
            this.ConnectionStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectionStatusLabel.Location = new System.Drawing.Point(11, 90);
            this.ConnectionStatusLabel.Name = "ConnectionStatusLabel";
            this.ConnectionStatusLabel.Size = new System.Drawing.Size(229, 28);
            this.ConnectionStatusLabel.TabIndex = 13;
            this.ConnectionStatusLabel.Text = "Not Connected";
            this.ConnectionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IPTextBox
            // 
            this.IPTextBox.AcceptsReturn = true;
            this.IPTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.IPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPTextBox.ForeColor = System.Drawing.Color.White;
            this.IPTextBox.Location = new System.Drawing.Point(14, 45);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(226, 26);
            this.IPTextBox.TabIndex = 12;
            this.IPTextBox.Text = "127.0.0.1:1234";
            this.IPTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IPTextBox_KeyPress);
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPLabel.ForeColor = System.Drawing.Color.White;
            this.IPLabel.Location = new System.Drawing.Point(10, 14);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(242, 28);
            this.IPLabel.TabIndex = 11;
            this.IPLabel.Text = "Enter IP and Port to Connect to:";
            // 
            // MessageListBox
            // 
            this.MessageListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.MessageListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageListBox.ForeColor = System.Drawing.Color.White;
            this.MessageListBox.FormattingEnabled = true;
            this.MessageListBox.ItemHeight = 19;
            this.MessageListBox.Location = new System.Drawing.Point(10, 175);
            this.MessageListBox.Name = "MessageListBox";
            this.MessageListBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MessageListBox.Size = new System.Drawing.Size(875, 175);
            this.MessageListBox.TabIndex = 20;
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(52)))));
            this.DisconnectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisconnectBtn.ForeColor = System.Drawing.Color.White;
            this.DisconnectBtn.Location = new System.Drawing.Point(272, 85);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(182, 39);
            this.DisconnectBtn.TabIndex = 21;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = false;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // TitleLabel2
            // 
            this.TitleLabel2.AutoSize = true;
            this.TitleLabel2.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel2.ForeColor = System.Drawing.Color.White;
            this.TitleLabel2.Location = new System.Drawing.Point(626, 31);
            this.TitleLabel2.Name = "TitleLabel2";
            this.TitleLabel2.Size = new System.Drawing.Size(119, 45);
            this.TitleLabel2.TabIndex = 26;
            this.TitleLabel2.Text = "CN-1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.White;
            this.TitleLabel.Location = new System.Drawing.Point(521, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(350, 45);
            this.TitleLabel.TabIndex = 25;
            this.TitleLabel.Text = "Chat Messenger";
            // 
            // OwnerLabel
            // 
            this.OwnerLabel.AutoSize = true;
            this.OwnerLabel.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerLabel.ForeColor = System.Drawing.Color.White;
            this.OwnerLabel.Location = new System.Drawing.Point(667, 124);
            this.OwnerLabel.Name = "OwnerLabel";
            this.OwnerLabel.Size = new System.Drawing.Size(206, 23);
            this.OwnerLabel.TabIndex = 27;
            this.OwnerLabel.Text = "Property of Ayaan and Rayyan ";
            // 
            // ClientWindow
            // 
            this.AcceptButton = this.SendBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(904, 609);
            this.Controls.Add(this.OwnerLabel);
            this.Controls.Add(this.TitleLabel2);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.MessageListBox);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.OutgoingLabel);
            this.Controls.Add(this.OutgoingTextBox);
            this.Controls.Add(this.IncomingLabel);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.ConnectionStatusLabel);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.IPLabel);
            this.MaximizeBox = false;
            this.Name = "ClientWindow";
            this.Text = "Client - Chat Messenger";
            this.Shown += new System.EventHandler(this.ClientWindow_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Label OutgoingLabel;
        private System.Windows.Forms.TextBox OutgoingTextBox;
        private System.Windows.Forms.Label IncomingLabel;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Label ConnectionStatusLabel;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.ListBox MessageListBox;
        private System.Windows.Forms.Button DisconnectBtn;
        private System.Windows.Forms.Label TitleLabel2;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label OwnerLabel;
    }
}

