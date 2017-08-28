using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace GitHubApp
{
    class EmailClient
    {
        /// <summary>
        /// Sends an email to each organization member that is missing a name on their GitHub profile
        /// </summary>
        /// <param name="SENDER_ADDRESS"></param>
        /// <param name="recipient"></param>
        /// <param name="SMTP_HOST"></param>
        /// <param name="PORT"></param>
        /// <param name="YOUR_EMAIL_PASSWORD"></param>
        public void SendEmail(string SENDER_ADDRESS, string recipient, string SMTP_HOST, string PORT, string YOUR_EMAIL_PASSWORD)
        {
            try
            {
                var message = new MailMessage(SENDER_ADDRESS, recipient);
                message.Subject = "Your GitHub User Profile Name";
                message.Body = "We have noticed that you do not have a name added to your GitHub profile. " +
                               "Please go to <a href='https://github.com/'></a>, log into your profile, and add a name to your account.";
                var mailer = new SmtpClient(SMTP_HOST, int.Parse(PORT));
                mailer.Credentials = new NetworkCredential(SENDER_ADDRESS, YOUR_EMAIL_PASSWORD);
                mailer.EnableSsl = true;
                mailer.Send(message);
            }

            catch (Exception)
            {
                MessageBox.Show("There was a problem sending the email");
            }
        }
    }
}
