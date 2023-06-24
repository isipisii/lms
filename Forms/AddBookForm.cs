using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;

namespace LibraryManagementSystem
{
    public partial class AddBookForm : Form
    {

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        // add book to db
        private void button1_Click(object sender, EventArgs e)
        {
            BLL_Book book = new BLL_Book();

            int qty = Convert.ToInt32(quantity.Value);

            if (titleTb.Text == "" && authorTb.Text == "" && quantity.Value == 0 && picBox.Image == null && description.Text == "")
            {
                MessageBox.Show("Please fill out all of the fields!");
            }
            else
            {
                if (book.SaveItems(titleTb.Text, authorTb.Text, qty, picBox.Image, description.Text))
                {
                    MessageBox.Show("Success!");
                    BooksUserControl booksUserControl = new BooksUserControl();
                    booksUserControl.GenerateDynamicUserControl();
                    Close();
                }   
                else
                {
                    MessageBox.Show("Failed!");
                }
            }

        }

       
        //upload image to pic box
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                picBox.Image = image;

            }
        }

        private void titleTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void updateBook_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBox_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
