using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.Forms;

namespace LibraryManagementSystem.UserControls
{
    public partial class BookCardUserControl1 : UserControl
    {   

        public BookCardUserControl1()
        {
            InitializeComponent();
        }

        private bool isInForm = false;
        private string _title;
        private string _author;
        private int _quantity;
        private Image _image;
        private int _id;
        private string _description;
        

        public bool IsInForm { get {return isInForm; }  set { isInForm = value; } }
        public Image Image { get { return _image; } set {  _image = value; pictureBox2.Image = value; } }


        public string Title { get { return _title; } set { _title = value; titleLabel.Text = value; } }

        public string Author { get { return _author;} set { _author = value; authorLabel.Text = value; } }


        public int Quantity { get { return _quantity; } set {  _quantity = value;  quantityLabel.Text = value.ToString(); } }

        public string Description { get { return _description; } set { _description = value; description.Text = value; } }

       
        public int Id { get { return _id; } set { _id = value; } }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookCardUserControl1_Load(object sender, EventArgs e)
        {
            if (IsInForm == true)
            {
                editBtn.Visible = false;
                deleteBtn.Visible = false;
                getBookBtn.Visible = true;
            }
            else
            {
                getBookBtn.Visible = false;
                editBtn.Visible = true;
                deleteBtn.Visible = true;
            }
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
  
        }

        private void quantityLabel_Click(object sender, EventArgs e)
        {

        }

        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
              
        }

        // edit btn
        // this will set the data from card and transfer it in the text boxes 
        private void button1_Click(object sender, EventArgs e)
        {
            EditBookForm editBookForm = new EditBookForm();
            editBookForm.UpdateFields(Title, Author, Quantity, Image, Id, Description);
            editBookForm.ShowDialog();
        }

        //delete book
        private void deleteBtn_Click(object sender, EventArgs e)
        {
           BLL_Book book = new BLL_Book();

            DialogResult result = MessageBox.Show("Do you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (book.DeleteBook(Id))
                {   
                    MessageBox.Show("Deleted!");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
           
        }

        //get button
        private void button1_Click_1(object sender, EventArgs e)
        {
            MakeBorrowForm makeBorrowForm = Application.OpenForms.OfType<MakeBorrowForm>().FirstOrDefault();

            if (Quantity <= 1)
            {
                MessageBox.Show("You can't get this book, this book has only one copy remaining. Please restock.");
            }
            else
            {
                if (makeBorrowForm != null)
                {
                    makeBorrowForm.UpdateBookLabels(Title, Id, Image);
                }
                else
                {
                    makeBorrowForm = new MakeBorrowForm();
                    makeBorrowForm.UpdateBookLabels(Title, Id, Image);
                    makeBorrowForm.Show();
                }

                BookListsForm bookListForm = Application.OpenForms.OfType<BookListsForm>().FirstOrDefault();
                if (bookListForm != null)
                {
                    bookListForm.Close();
                }
            }
           
        }
    }
}
