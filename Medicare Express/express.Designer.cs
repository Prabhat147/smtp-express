using System;

namespace Medicare_Express
{
    partial class express
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
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(41, 71);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(300, 29);
            this.txtSender.TabIndex = 10;
            this.txtSender.TextChanged += new System.EventHandler(this.txtSender_TextChanged);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(426, 71);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(300, 29);
            this.txtReceiver.TabIndex = 11;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(41, 177);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(685, 284);
            this.txtMessage.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(774, 292);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(89, 41);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // lblSender
            // 
            this.lblSender.Location = new System.Drawing.Point(36, 36);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(100, 23);
            this.lblSender.TabIndex = 14;
            this.lblSender.Text = "Sender Email:";
            // 
            // lblReceiver
            // 
            this.lblReceiver.Location = new System.Drawing.Point(421, 36);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(100, 23);
            this.lblReceiver.TabIndex = 15;
            this.lblReceiver.Text = "Receiver Email:";
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(36, 132);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(100, 23);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "Message:";
            // 
            // express
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 493);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.txtReceiver);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "express";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medicare Express";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private void txtSender_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblMessage;
    }
}