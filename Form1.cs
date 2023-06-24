using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.UserControls;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {   
        
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            dashboardUserControl1.BringToFront();
        }

        //Home Tab
        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            dashboardUserControl1.BringToFront();
        }
   
        //Books Tab
        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            booksUserControl1.BringToFront();
        }   

        //Students Tab
        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            studentsUserControl1.BringToFront();
        }

        //Borrows Tab
        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            borrows1.BringToFront();
        }

        private void borrows1_Load(object sender, EventArgs e)
        {

        }
        private void borrows1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
