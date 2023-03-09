using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cusine_System
{
    public partial class SignUpForm : Form
    {

        public SignUpForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void SignUp_Click(object sender, EventArgs e)
        {

            String[] lines = File.ReadAllLines("users.txt");


            bool isAlreadyPresent = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(',');
                if (temp[2].Equals(email.Text))
                {
                    isAlreadyPresent = true;
                    break;
                }
            }

            if (isAlreadyPresent)
            {
                MessageBox.Show("User is already present! with the given email address!, Kindly Log in.");


            }
            else
            {
                FileInfo file = new FileInfo("users.txt");
                StreamWriter sw = file.AppendText();

                sw.WriteLine(this.name.Text + "," + (radioButton1.Checked ? "Male," : "Female,") + email.Text + "," + password.Text);
            
                sw.Close();
                Dispose();

                MessageBox.Show("Your account has been successfully created, you can sign in now.");
                new Welcome();
            }



        }
    }
}
