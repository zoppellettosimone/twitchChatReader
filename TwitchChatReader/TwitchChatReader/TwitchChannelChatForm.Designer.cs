
namespace TwitchChatReader
{
    partial class TwitchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitchForm));
            this.UserBotton = new ReaLTaiizor.Controls.ParrotButton();
            this.label4 = new System.Windows.Forms.Label();
            this.channelTextBox = new ReaLTaiizor.Controls.TextBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new ReaLTaiizor.Controls.ParrotButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserBotton
            // 
            this.UserBotton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.UserBotton.ButtonImage = null;
            this.UserBotton.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.UserBotton.ButtonText = "Close";
            this.UserBotton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.UserBotton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.UserBotton.CornerRadius = 5;
            this.UserBotton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserBotton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.UserBotton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.UserBotton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.UserBotton.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.UserBotton.Location = new System.Drawing.Point(308, 12);
            this.UserBotton.Name = "UserBotton";
            this.UserBotton.Size = new System.Drawing.Size(80, 35);
            this.UserBotton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.UserBotton.TabIndex = 24;
            this.UserBotton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.UserBotton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.UserBotton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.UserBotton.Click += new System.EventHandler(this.UserBotton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(94)))));
            this.label4.Location = new System.Drawing.Point(80, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 25;
            this.label4.Text = "Twitch Chat Reader";
            // 
            // channelTextBox
            // 
            this.channelTextBox.BackColor = System.Drawing.Color.Transparent;
            this.channelTextBox.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.channelTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(183)))), ((int)(((byte)(191)))));
            this.channelTextBox.Image = null;
            this.channelTextBox.Location = new System.Drawing.Point(80, 250);
            this.channelTextBox.MaxLength = 32767;
            this.channelTextBox.Multiline = false;
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.ReadOnly = false;
            this.channelTextBox.Size = new System.Drawing.Size(233, 41);
            this.channelTextBox.TabIndex = 26;
            this.channelTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.channelTextBox.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(86)))), ((int)(((byte)(94)))));
            this.label1.Location = new System.Drawing.Point(80, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Twitch Channel:";
            // 
            // sendButton
            // 
            this.sendButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(70)))), ((int)(((byte)(75)))));
            this.sendButton.ButtonImage = null;
            this.sendButton.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.Dark;
            this.sendButton.ButtonText = "Open Chat";
            this.sendButton.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(80)))));
            this.sendButton.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.sendButton.CornerRadius = 5;
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendButton.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.sendButton.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.sendButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(215)))));
            this.sendButton.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.sendButton.Location = new System.Drawing.Point(153, 323);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(86, 35);
            this.sendButton.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.sendButton.TabIndex = 28;
            this.sendButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(200)))), ((int)(((byte)(185)))));
            this.sendButton.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.sendButton.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // TwitchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(400, 382);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UserBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwitchForm";
            this.Text = "Twitch Chat Reader";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotButton UserBotton;
        private System.Windows.Forms.Label label4;
        private ReaLTaiizor.Controls.TextBoxEdit channelTextBox;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.ParrotButton sendButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

