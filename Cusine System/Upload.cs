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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Cusine_System
{
    public partial class Upload : Form
    {
        string tempName;
        public Upload(string name)
        {
            tempName = name;
            InitializeComponent();
            this.Visible = true;

        }
        private void upload_btn_Click(object sender, EventArgs e)
        {
            
           

            Dispose();
            new MainFeed(tempName);

        }

   

        private void load_Click(object sender, EventArgs e)
        {
            DialogResult =  openFileDialog1.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                description.Text = openFileDialog1.SafeFileName;


                string sourceFile = openFileDialog1.FileName;

                try
                {
                  

                    File.Copy(sourceFile, "videos//" + openFileDialog1.SafeFileName, true);

                }

                catch (IOException e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
