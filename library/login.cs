using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace library
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {





















        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button_login_Click(object sender, EventArgs e)
        {

            if (username.Text =="HASSAN" && PASSWORD.Text=="ADMIN" ) 
            {
                
                Form1 f = new Form1(username.Text);
                
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("error username or password is wrong");
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
