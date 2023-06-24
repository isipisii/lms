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

namespace LibraryManagementSystem.Forms
{
    public partial class MakeBorrowForm : Form
    {
        private int bookId;
        private int studentId;
        private bool isInEdit = false;
        private int borrowId;
        public MakeBorrowForm()
        {
            InitializeComponent();
            
           
        }
    
        public bool IsInEdit { get { return isInEdit; } set {  isInEdit = value; } }

        //for editing
        public void UpdateEditFields(int borrow_id,  int student_id, int book_id, string bookTitle, string borrowerFn, DateTime dueDate, DateTime borrowDate, Image bookImg)
        {
            bookTitleLbl.Text = bookTitle;
            borrowerLbl.Text = borrowerFn;
            dueDatePicker.Value = dueDate;
            dateBorrowedPicker.Value = borrowDate;
            bookPb.Image = bookImg;
            borrowId = borrow_id;
            studentId = student_id;
            bookId = book_id;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //show student list
        private void showStudentBtn_Click(object sender, EventArgs e)
        {
            StudentListsForm studentListsForm = new StudentListsForm();
            studentListsForm.ShowDialog();
        }

        //show book list 
        private void showBooksBtn_Click(object sender, EventArgs e)
        {
            BookListsForm bookListsForm = new BookListsForm(); 
            bookListsForm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void UpdateBookLabels(string title, int id, Image bookPic)
        {
            bookTitleLbl.Text = title;
            bookId = id;
            bookPb.Image = bookPic;
        }

        public void UpdateBorrowerLabels(string borrowerFn, int id)
        {
            borrowerLbl.Text = borrowerFn;
            studentId = id;
        }


        // create borrow btn
        private void button2_Click(object sender, EventArgs e)
        { 
            BLL_Borrow bLL_Borrow = new BLL_Borrow();

            if(bLL_Borrow.CheckBorrowsIfExist(studentId, bookId))
            {
                MessageBox.Show("This student has an existing borrow!");
            } else
            {
                if (bLL_Borrow.MakeBorrow(studentId, bookId, dateBorrowedPicker.Value, dueDatePicker.Value))
                {
                    MessageBox.Show("Borrow created successfully!");
                    Close();
                }
                else
                {
                    MessageBox.Show("An error occured while creating borrow");
                }
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MakeBorrowForm_Load(object sender, EventArgs e)
        {
            if (IsInEdit == true)
            {
                modalText.Text = "Edit a borrow";
                updateBtn.Visible = true;
                borrowBtn.Visible = false;
            }
            else
            {
                modalText.Text = "Create a borrow";
                updateBtn.Visible = false;
                borrowBtn.Visible = true;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            BLL_Borrow bLL_Borrow = new BLL_Borrow();

            if (bLL_Borrow.UpdateBorrow(borrowId, studentId, bookId, dateBorrowedPicker.Value, dueDatePicker.Value))
            {
                MessageBox.Show("Updated successfully!");
                Close();
            }
            else
            {
                MessageBox.Show("An error occured while updating");
            }
        }
    }
}
