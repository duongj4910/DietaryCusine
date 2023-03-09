using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cusine_System
{
    public partial class Welcome : Form
    {
        string msg = "WELCOME TO DIETARY CUSINES" ; 
        int index;
        public Welcome()
        {
            index = 0;
            InitializeComponent();
            this.Visible = true;
            

        }

      
        private void Welcome_Load(object sender, EventArgs e)
        {

            timer1.Enabled = true;
        }
    

        private void SignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUpForm();
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignInForm();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (index != msg.Length)
            {
                label1.Text += msg[index++];
            }
            else
            {
                timer1.Enabled = false;
                index = 0;
                label1.Text = "";
                timer1.Enabled = true;
            }
                
        }
    }
}
