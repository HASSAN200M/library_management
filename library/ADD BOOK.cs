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
    public partial class ADD_BOOK : Form
    {
      
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BUTTONADD_BOOK_Click(object sender, EventArgs e)
        {
          
            

        }

        private void ADD_BOOK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_dataDataSet1.TB_CAT' table. You can move, or remove it, as needed.
            this.tB_CATTableAdapter.Fill(this.library_dataDataSet1.TB_CAT);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
