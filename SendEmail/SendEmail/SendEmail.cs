using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;

namespace SendEmail
{
    public class SendEmail
    {
        private string sender;
        private string password;
        private string recipient;
        private string subject;
        private string body;
        private int sendAttempts = 0;
        private bool status;

        public bool sendMail()
        {
            sendAttempts++;
            SmtpClient Client = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = sender,
                    Password = password
                }
            };
            MailAddress recipientAdd = new MailAddress(recipient);
            MailAddress senderAdd = new MailAddress(sender);
            MailMessage email = new MailMessage()
            {
                From = senderAdd,
                Subject = subject,
                Body = body
            };
            email.To.Add(recipientAdd);
            Client.SendCompleted += Client_SendCompleted;
            Client.SendMailAsync(email);
            return status;
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null) 
            {
                if (sendAttempts < 3)
                {
                    sendMail();
                }
                else
                {
                    status = false;
                    return;
                }
            }
            status = true;
        }

        public void setSender(string s)
        {
            this.sender = s;
        }
        public string getSender()
        {
            return this.sender;
        }
        public void setPassword(string p)
        {
            this.password = p;
        }
        public string getPassword()
        {
            return this.password;
        }
        public void setRecipient(string r)
        {
            this.recipient = r;
        }
        public string getRecipient()
        {
            return this.recipient;
        }
        public void setSubject(string sub)
        {
            this.subject = sub;
        }
        public string getSubject()
        {
            return this.subject;
        }
        public void setBody(string b)
        {
            this.body = b;
        }
        public string getBody()
        {
            return this.body;
        }

        public SendEmail(string s, string p, string r, string sub, string b)
        {
            this.subject = s;
            this.password = p;
            this.recipient = r;
            this.subject = sub;
            this.body = b;
        }
    }
}
