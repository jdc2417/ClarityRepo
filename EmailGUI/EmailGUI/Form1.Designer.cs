
namespace EmailGUI
{
    partial class mailForm
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
            this.senderBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.toBox = new System.Windows.Forms.TextBox();
            this.subBox = new System.Windows.Forms.TextBox();
            this.bodyBox = new System.Windows.Forms.RichTextBox();
            this.senderLbl = new System.Windows.Forms.Label();
            this.senderPassLbl = new System.Windows.Forms.Label();
            this.toLbl = new System.Windows.Forms.Label();
            this.subjectLbl = new System.Windows.Forms.Label();
            this.bodyLbl = new System.Windows.Forms.Label();
            this.sendBut = new System.Windows.Forms.Button();
            this.exitBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // senderBox
            // 
            this.senderBox.Location = new System.Drawing.Point(142, 32);
            this.senderBox.Name = "senderBox";
            this.senderBox.Size = new System.Drawing.Size(350, 22);
            this.senderBox.TabIndex = 0;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(142, 61);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(350, 22);
            this.passBox.TabIndex = 2;
            this.passBox.UseSystemPasswordChar = true;
            // 
            // toBox
            // 
            this.toBox.Location = new System.Drawing.Point(142, 153);
            this.toBox.Name = "toBox";
            this.toBox.Size = new System.Drawing.Size(350, 22);
            this.toBox.TabIndex = 3;
            // 
            // subBox
            // 
            this.subBox.Location = new System.Drawing.Point(140, 248);
            this.subBox.Name = "subBox";
            this.subBox.Size = new System.Drawing.Size(352, 22);
            this.subBox.TabIndex = 5;
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(140, 291);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(352, 160);
            this.bodyBox.TabIndex = 6;
            this.bodyBox.Text = "";
            // 
            // senderLbl
            // 
            this.senderLbl.AutoSize = true;
            this.senderLbl.Location = new System.Drawing.Point(12, 35);
            this.senderLbl.Name = "senderLbl";
            this.senderLbl.Size = new System.Drawing.Size(96, 17);
            this.senderLbl.TabIndex = 7;
            this.senderLbl.Text = "Sender Email:";
            // 
            // senderPassLbl
            // 
            this.senderPassLbl.AutoSize = true;
            this.senderPassLbl.Location = new System.Drawing.Point(12, 61);
            this.senderPassLbl.Name = "senderPassLbl";
            this.senderPassLbl.Size = new System.Drawing.Size(73, 17);
            this.senderPassLbl.TabIndex = 9;
            this.senderPassLbl.Text = "Password:";
            // 
            // toLbl
            // 
            this.toLbl.AutoSize = true;
            this.toLbl.Location = new System.Drawing.Point(12, 156);
            this.toLbl.Name = "toLbl";
            this.toLbl.Size = new System.Drawing.Size(29, 17);
            this.toLbl.TabIndex = 10;
            this.toLbl.Text = "To:";
            // 
            // subjectLbl
            // 
            this.subjectLbl.AutoSize = true;
            this.subjectLbl.Location = new System.Drawing.Point(12, 251);
            this.subjectLbl.Name = "subjectLbl";
            this.subjectLbl.Size = new System.Drawing.Size(59, 17);
            this.subjectLbl.TabIndex = 12;
            this.subjectLbl.Text = "Subject:";
            // 
            // bodyLbl
            // 
            this.bodyLbl.AutoSize = true;
            this.bodyLbl.Location = new System.Drawing.Point(12, 294);
            this.bodyLbl.Name = "bodyLbl";
            this.bodyLbl.Size = new System.Drawing.Size(44, 17);
            this.bodyLbl.TabIndex = 13;
            this.bodyLbl.Text = "Body:";
            // 
            // sendBut
            // 
            this.sendBut.Location = new System.Drawing.Point(15, 460);
            this.sendBut.Name = "sendBut";
            this.sendBut.Size = new System.Drawing.Size(230, 80);
            this.sendBut.TabIndex = 14;
            this.sendBut.Text = "Send";
            this.sendBut.UseVisualStyleBackColor = true;
            this.sendBut.Click += new System.EventHandler(this.sendBut_Click);
            // 
            // exitBut
            // 
            this.exitBut.Location = new System.Drawing.Point(262, 461);
            this.exitBut.Name = "exitBut";
            this.exitBut.Size = new System.Drawing.Size(230, 80);
            this.exitBut.TabIndex = 15;
            this.exitBut.Text = "Exit";
            this.exitBut.UseVisualStyleBackColor = true;
            this.exitBut.Click += new System.EventHandler(this.exitBut_Click);
            // 
            // mailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 553);
            this.Controls.Add(this.exitBut);
            this.Controls.Add(this.sendBut);
            this.Controls.Add(this.bodyLbl);
            this.Controls.Add(this.subjectLbl);
            this.Controls.Add(this.toLbl);
            this.Controls.Add(this.senderPassLbl);
            this.Controls.Add(this.senderLbl);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.subBox);
            this.Controls.Add(this.toBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.senderBox);
            this.Name = "mailForm";
            this.Text = "Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox senderBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.TextBox toBox;
        private System.Windows.Forms.TextBox subBox;
        private System.Windows.Forms.RichTextBox bodyBox;
        private System.Windows.Forms.Label senderLbl;
        private System.Windows.Forms.Label senderPassLbl;
        private System.Windows.Forms.Label toLbl;
        private System.Windows.Forms.Label subjectLbl;
        private System.Windows.Forms.Label bodyLbl;
        private System.Windows.Forms.Button sendBut;
        private System.Windows.Forms.Button exitBut;
    }
}

