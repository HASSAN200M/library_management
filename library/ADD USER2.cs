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
    public partial class ADD_USER2 : Form
    {
       
        public ADD_USER2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_USER2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_dataDataSet11.VALIDITY' table. You can move, or remove it, as needed.
            this.vALIDITYTableAdapter.Fill(this.library_dataDataSet11.VALIDITY);

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
