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
    public partial class EditBookForm : Form
    {

        private int bookId;

        public int QuantityValue
        {
            get { return (int)quantity.Value; }
            set { quantity.Value = value; }
        }

        public EditBookForm()
        {
            InitializeComponent();
        }

        private void updateBook_Click(object sender, EventArgs e)
        {
            BLL_Book book = new BLL_Book();

            if (titleTb.Text == "" && authorTb.Text == "" && quantity.Value == 0 && picBox.Image == null && description.Text == "")
            {
                MessageBox.Show("Please fill out all of the fields!");
            }
            else
            {
                int qty = Convert.ToInt32(quantity.Value);
                if (book.UpdateBook(bookId, titleTb.Text, authorTb.Text, qty, picBox.Image, description.Text))
                {
                    MessageBox.Show("Success!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed!");
                    Close();
                }
            }
        }

        public void UpdateFields(string title, string author, int quantity, Image image, int id, string desc)
        {
            titleTb.Text = title;
            authorTb.Text = author;
            QuantityValue = quantity;
            picBox.Image = image;
            description.Text = desc;
            bookId = id;
        }

        // upload image to pic box
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);
                picBox.Image = image;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
