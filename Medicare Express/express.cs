using System;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Medicare_Express
{
    public partial class express : Form
    {
        public express()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtSender.Text))
            {
                MessageBox.Show("Sender email is empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtReceiver.Text))
            {
                MessageBox.Show("Receiver email is empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMessage.Text))
            {
                MessageBox.Show("Message is empty.");
                return;
            }

            // Validate email formats
            if (!IsValidEmail(txtSender.Text))
            {
                MessageBox.Show("Invalid sender email format. Please use a valid Gmail address.");
                return;
            }

            if (!IsValidEmail(txtReceiver.Text))
            {
                MessageBox.Show("Invalid receiver email format. Please use a valid Gmail address.");
                return;
            }

            try
            {
                //user input
                string senderEmail = txtSender.Text;
                string receiverEmail = txtReceiver.Text;
                string message = txtMessage.Text;

                // Emails and passwods here
                string emailhere = "";
                string passwordhere = "";

                // Configure the SMTP client
                SmtpClient smtpServer = new SmtpClient
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(emailhere, passwordhere), 
                    // Use secure methods for credentials
                    Port = 587,
                    EnableSsl = true,
                    Host = "smtp.gmail.com"
                };

                // Create the email message
                MailMessage email = new MailMessage
                {
                    From = new MailAddress(txtSender.Text),
                    Subject = "Email Sending",
                    IsBodyHtml = false,
                    Body = txtMessage.Text
                };
                email.To.Add(txtReceiver.Text);

                // Send the email
                smtpServer.Send(email);
                MessageBox.Show("Mail Sent", "Success");
            }
            catch (SmtpException smtpEx)
            {
                MessageBox.Show($"SMTP Error: {smtpEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while sending mail: {ex.Message}", "Error");
            }
        }

        private bool IsValidEmail(string email)
        {
            // Regular expression to validate Gmail format
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
