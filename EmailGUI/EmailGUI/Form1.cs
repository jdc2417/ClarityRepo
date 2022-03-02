using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SendEmail;//dll I created
using System.Xml;//xml library for appsettings

namespace EmailGUI
{
    public partial class mailForm : Form
    {
        public mailForm()
        {
            InitializeComponent();//initialize form
        }

        private async void sendBut_Click(object sender, EventArgs e)
        {
            string tempName;//temp variables to store what is retrieved from appsettings
            string tempPass;
            using (XmlWriter createCredentials = XmlWriter.Create("credentials.xml"))//attempt to create xml file with credentials
            {
                createCredentials.WriteStartElement("credentials");
                createCredentials.WriteElementString("username", senderBox.Text);
                createCredentials.WriteElementString("password", passBox.Text);
                createCredentials.WriteEndElement();
                createCredentials.Flush();
            }
            using (XmlReader readCredentials = XmlReader.Create("credentials.xml"))//attempt to read xml file with credentials
            {
                readCredentials.ReadStartElement("credentials");
                tempName = readCredentials.ReadElementString("username");//setting temp variables to retrieved info
                tempPass = readCredentials.ReadElementString("password");
                readCredentials.ReadEndElement();
            }
            //Construct new instance of SendEmail and pass info in the GUI
            SendEmail.SendEmail newMail = new SendEmail.SendEmail(tempName, tempPass, toBox.Text, subBox.Text, bodyBox.Text);
            await newMail.SendMail();
            if (newMail.getStatus() == true)//if the email is successfully sent
            {
                MessageBox.Show("Mail Sent!");//alert user
                using (StreamWriter sw = File.AppendText("log.txt"))//initialize stream writer
                {
                    //log data in a persistant form
                    sw.WriteLine(senderBox.Text + ", " + toBox.Text + ", " + subBox.Text + ", " + bodyBox.Text + ", " + DateTime.Now + ", Send Successful");
                    sw.Flush();
                }
            }
            else//if the email did not send after 3 attempts
            {
                MessageBox.Show("An error occurred.");//alert user
                using (StreamWriter sw = File.AppendText("log.txt"))//initialize stream writer
                {
                    //log data in a persistant form
                    sw.WriteLine(senderBox.Text + ", " + toBox.Text + ", " + subBox.Text + ", " + bodyBox.Text + ", " + DateTime.Now + ", Send Failed");
                    sw.Flush();
                }
                    
            }
            
        }

        

        private void exitBut_Click(object sender, EventArgs e)//when exit button is clicked
        {
            Application.Exit();//exit program
        }
    }
}
