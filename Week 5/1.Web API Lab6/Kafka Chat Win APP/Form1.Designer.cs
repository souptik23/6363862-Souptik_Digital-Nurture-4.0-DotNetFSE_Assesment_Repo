namespace KafkaChatWinApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtChat = new TextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.Location = new Point(15, 15);
            txtChat.Margin = new Padding(4, 4, 4, 4);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.ScrollBars = ScrollBars.Vertical;
            txtChat.Size = new Size(949, 374);
            txtChat.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(15, 412);
            txtMessage.Margin = new Padding(4, 4, 4, 4);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(749, 31);
            txtMessage.TabIndex = 1;
            txtMessage.TextChanged += txtMessage_TextChanged;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(789, 412);
            btnSend.Margin = new Padding(4, 4, 4, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(175, 34);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 525);
            Controls.Add(txtChat);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Kafka Chat Client";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}