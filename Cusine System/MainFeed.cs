using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cusine_System
{
    public partial class MainFeed : Form
    {
        string userName;
        public MainFeed(string temp)
        {
            userName = temp;    
            InitializeComponent();
            this.Visible = true;

            
            axWindowsMediaPlayer1.URL = "videos//Welcome!.mp4";
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.name.Text = temp;
        }

        private void upload_Click(object sender, EventArgs e)
        {
            Dispose();
            new Upload(userName);
        }

        private void signOut_Click(object sender, EventArgs e)
        {
            Dispose();
            new Welcome();
        }
    }
}
