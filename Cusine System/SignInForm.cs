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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cusine_System
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void SignIn_Click(object sender, EventArgs e)
        {

            String[] lines = File.ReadAllLines("users.txt");

            bool isPresent = false;

            string name = "";
            for (int i = 0; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split(',');
                if (temp[2].Equals(emailField.Text) && temp[3].Equals(passwordField.Text))
                {
                    name = temp[0];
                    isPresent = true;
                    break;
                }
            }

            if (isPresent)
            {
                Dispose();
                new MainFeed(name);


            }
            else
            {
                MessageBox.Show("Email or password are incorrect!");
            }

        }
    }
}
