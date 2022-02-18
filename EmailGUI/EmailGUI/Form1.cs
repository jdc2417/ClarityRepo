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

namespace EmailGUI
{
    public partial class mailForm : Form
    {
        public mailForm()
        {
            InitializeComponent();//initialize form
        }

        private void sendBut_Click(object sender, EventArgs e)
        {
            //Construct new instance of SendEmail and pass info in the GUI
            SendEmail.SendEmail newMail = new SendEmail.SendEmail(senderBox.Text, passBox.Text, toBox.Text, subBox.Text, bodyBox.Text);
            if (newMail.sendMail() == true)//if the email is successfully sent
            {
                MessageBox.Show("Mail Sent!");//alert user
                using (StreamWriter sw = File.AppendText("./log.txt"))//initialize stream writer
                {
                    //log data in a persistant form
                    sw.WriteLine(senderBox.Text + ", " + toBox.Text + ", " + subBox + ", " + bodyBox + ", " + DateTime.Today + ", Send Successful");
                }
            }
            else//if the email did not send after 3 attempts
            {
                MessageBox.Show("An error occurred.");//alert user
                using (StreamWriter sw = File.AppendText("./log.txt"))//initialize stream writer
                {
                    //log data in a persistant form
                    sw.WriteLine(senderBox.Text + ", " + toBox.Text + ", " + subBox + ", " + bodyBox + ", " + DateTime.Today + ", Send Failed");
                }
                    
            }
            
        }

        

        private void exitBut_Click(object sender, EventArgs e)//when exit button is clicked
        {
            Application.Exit();//exit program
        }
    }
}
