using System;
using System.ComponentModel;
using System.Net;
using System.IO;
using System.Net.Mail;//email library
using System.Xml;
using System.Configuration;
using System.Threading.Tasks;

namespace SendEmail
{
    public class SendEmail
    {
        //data members
        private string sender;
        private string password;
        private string recipient;
        private string subject;
        private string body;
        private int sendAttempts = 0;
        public bool status;

        public async Task SendMail()//main method of dll
        {
            sendAttempts++;//every time a send is attempted, increment sendAttempts

            try
            {
                SmtpClient Client = new SmtpClient()//initialize email client
                {
                    Host = "smtp.gmail.com",//initialize email data
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = sender,//credentials from appsettings
                        Password = password
                    }
                };
                //declare two sides of the email and the email itself
                MailAddress recipientAdd = new MailAddress(recipient, recipient);
                MailAddress senderAdd = new MailAddress(sender, sender);
                MailMessage email = new MailMessage()
                {
                    From = senderAdd,
                    Subject = subject,
                    Body = body
                };
                //add recipient to email
                email.To.Add(recipientAdd);
                Client.SendCompleted += Client_SendCompleted;
                await Client.SendMailAsync(email);
            }
            catch//if an error occurs in the sending
            {
                Console.WriteLine("Error in email credentials.");//report to user
            }
            //return status;//return true of false based on if the email sent
        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)//event handler for the sending of the email
        {
            if (e.Error != null)//if an error occurred 
            {
                if (sendAttempts < 3)//if it hasnt attemoted to send the email 3 times
                {
                    SendMail();//attempt to send again
                }
                else//if 3 attempts have been made
                {
                    this.status = false;//set status to false
                    return;//exit event handler
                }
            }
            this.status = true;//if no error occurred, set status to true to show the email sent
        }

        //getters and setters just in case, even though they arent used in this program
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
        public bool getStatus()
        {
            return this.status;
        }

        public SendEmail(string s, string p, string r, string sub, string b)//constructor
        {
            //initialize information from form
            this.sender = s;
            this.password = p;
            this.recipient = r;
            this.subject = sub;
            this.body = b;
        }
    }
}
