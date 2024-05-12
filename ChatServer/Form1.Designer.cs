namespace ChatServer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtReceivedMessages = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.sendAllBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(796, 49);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 60);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtReceivedMessages
            // 
            this.txtReceivedMessages.BackColor = System.Drawing.Color.White;
            this.txtReceivedMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedMessages.Location = new System.Drawing.Point(29, 26);
            this.txtReceivedMessages.Margin = new System.Windows.Forms.Padding(4);
            this.txtReceivedMessages.Multiline = true;
            this.txtReceivedMessages.Name = "txtReceivedMessages";
            this.txtReceivedMessages.ReadOnly = true;
            this.txtReceivedMessages.Size = new System.Drawing.Size(737, 389);
            this.txtReceivedMessages.TabIndex = 1;
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(29, 431);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(737, 107);
            this.txtMsg.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(784, 450);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(123, 60);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.ItemHeight = 16;
            this.clientsListBox.Location = new System.Drawing.Point(796, 173);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.clientsListBox.Size = new System.Drawing.Size(151, 196);
            this.clientsListBox.TabIndex = 4;
            // 
            // sendAllBtn
            // 
            this.sendAllBtn.Location = new System.Drawing.Point(926, 450);
            this.sendAllBtn.Name = "sendAllBtn";
            this.sendAllBtn.Size = new System.Drawing.Size(114, 60);
            this.sendAllBtn.TabIndex = 5;
            this.sendAllBtn.Text = "Send All";
            this.sendAllBtn.Click += new System.EventHandler(this.sendAllBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.sendAllBtn);
            this.Controls.Add(this.clientsListBox);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtReceivedMessages);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtReceivedMessages;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox clientsListBox;
        private DevExpress.XtraEditors.SimpleButton sendAllBtn;
    }
}

