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
    public partial class Form1 : Form
    {
       
       
       
        public Form1(string UN)
        {
            InitializeComponent();
         
            label1.Text = UN;


        }
     
       
        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'library_dataDataSet12.USERS' table. You can move, or remove it, as needed.
            //this.uSERSTableAdapter.Fill(this.library_dataDataSet12.USERS);
            //// TODO: This line of code loads data into the 'library_dataDataSet10.SALE' table. You can move, or remove it, as needed.
            //this.sALETableAdapter.Fill(this.library_dataDataSet10.SALE);

            //this.tB_CATTableAdapter.Fill(this.library_dataDataSet1.TB_CAT);
            //// TODO: This line of code loads data into the 'library_dataDataSet.BOOK' table. You can move, or remove it, as needed.
            //this.bOOKTableAdapter.Fill(this.library_dataDataSet.BOOK);
            //// TODO: This line of code loads data into the 'library_dataDataSet1.TB_CAT' table. You can move, or remove it, as needed.
            //this.tB_CATTableAdapter.Fill(this.library_dataDataSet1.TB_CAT);

            panelHOME.Visible = true;
            panel_BOOK.Visible = false;
           

            panelSALE.Visible = false;
            panel_USER.Visible = false;
            labeltila.Text = "HOME";
        }
        private void buttoncolorchange(Button btn1, Button btn2, Button btn3, Button btn4)
        {
           
            btn1.BackColor = Color.FromArgb(196, 196, 196);
            btn2.BackColor = Color.Transparent;
            btn3.BackColor = Color.Transparent;
            btn4.BackColor = Color.Transparent;
        



        }
        private void buttoncolorchangeCOLOR(Button btn1, Button btn2, Button btn3, Button btn4)
        {

            btn1.ForeColor = Color.Black;
            btn2.ForeColor = Color.White;
            btn3.ForeColor = Color.White;
            btn4.ForeColor = Color.White;








        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void button1_Click_4(object sender, EventArgs e)
        {
            ADD_BOOK B = new ADD_BOOK();
            B.Show();

           
            

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            
            labeltila.Text = "HOME";
            panelHOME.Visible = true;
            panel_BOOK.Visible = false;
            
           
            panelSALE.Visible = false;
            panel_USER.Visible = false;
        }

      
        private void buttonUSER_Click_1(object sender, EventArgs e)
        {
          
            panelHOME.Visible = false;
            panel_BOOK.Visible = false;
            
       
            panelSALE.Visible = false;
            panel_USER.Visible = true;
            labeltila.Text = "USER";
            buttoncolorchange(buttonUSER, buttonBOOK, BUTTON_SAEL,buttonHOME );
            buttoncolorchangeCOLOR(buttonUSER, buttonBOOK, BUTTON_SAEL, buttonHOME);
        }

        

     
        private void BUTTON_MODIFY_BOOK_Click(object sender, EventArgs e)
        {
           
        }

        

        private void buttonBOOK_Click_1(object sender, EventArgs e)
        {
            panelHOME.Visible = false;
            panel_BOOK.Visible = false;
          
           
            panelSALE.Visible = false;
            panel_USER.Visible = false;
            labeltila.Text = "BOOKS";

        }

        private void buttonHOME_Click_1(object sender, EventArgs e)
        {
            panelHOME.Visible = true;
            panel_BOOK.Visible = false;
           
           
            panelSALE.Visible = false;
            panel_USER.Visible = false;
            labeltila.Text = "HOME";
             buttoncolorchange(buttonHOME, buttonBOOK, BUTTON_SAEL,buttonUSER);
           buttoncolorchangeCOLOR(buttonHOME, buttonBOOK, BUTTON_SAEL, buttonUSER);
        }

        private void buttonBOOK_Click_2(object sender, EventArgs e)
        {
            panelHOME.Visible = false;
            panel_BOOK.Visible = true;
         
            
            panelSALE.Visible = false;
            panel_USER.Visible = false;
            labeltila.Text = "BOOKS";
            buttoncolorchange( buttonBOOK,buttonHOME, BUTTON_SAEL, buttonUSER);
            buttoncolorchangeCOLOR(buttonBOOK, buttonHOME, BUTTON_SAEL, buttonUSER);


        }

       

        private void button13_Click(object sender, EventArgs e)
        {
            panelHOME.Visible = false;
            panel_BOOK.Visible = false;
           
            panelSALE.Visible = false;
            panel_USER.Visible = false;
            labeltila.Text = "BORROW";
        }

        private void BUTTON_SAEL_Click(object sender, EventArgs e)
        {
            panelHOME.Visible = false;
            panel_BOOK.Visible = false;
           
           
            panelSALE.Visible = true;
            panel_USER.Visible = false;
            labeltila.Text = "SAEL";
            buttoncolorchange( BUTTON_SAEL,buttonBOOK, buttonHOME, buttonUSER);
            buttoncolorchangeCOLOR(BUTTON_SAEL, buttonBOOK, buttonHOME, buttonUSER);
        }

       

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

 
        private void button15_Click(object sender, EventArgs e)
        {
          
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ADD_SAEL N = new ADD_SAEL();
            N.Show();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            ADD_USER2 U = new ADD_USER2();
            U.Show();
        }

        private void panel_customer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuMaterialTextbox13_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void panelSALE_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void button17_Click(object sender, EventArgs e)
        {
            
           
        }

        

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelBOOK_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {/// count book
          


            ////count users
         



          
        }

        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
               
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox7_OnValueChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonEIDETUSER_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonDELETEUSER_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelHOME_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}