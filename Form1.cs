using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fr4meC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //creating a fixed size and disabling maximize as there's no reason to change the size of the program
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string to read back text of button, therefore naming the program in the MsgBox
            string bTitle = this.button1.Text;

           
            {
        {
            {
                       
                WebRequest wr = WebRequest.Create(new Uri("https://tjloudon.me/ver/frm/version.txt"));

                WebResponse ws = wr.GetResponse();
                StreamReader sr = new StreamReader(ws.GetResponseStream());

                        string currentver = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                string newver = sr.ReadToEnd();


                if (currentver.Contains(newver))
                {
                            MessageBox.Show("Program " + bTitle + " is up to date at build " + newver + ".");
                }
                else
                {
                            TaskDialog dialog = new TaskDialog();
                            dialog.InstructionText = "Out of Date!";
                            dialog.Text = "Your build of " + bTitle + " is out of date! It is recommended that you update, but this is optional.";
                            dialog.Icon = TaskDialogStandardIcon.Error;
                            dialog.FooterText = "The newest build of " + bTitle + " is " + newver + ".";
                            dialog.Show();

                        }
                
            }
        }
    }

}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
