using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Forms;

namespace LibraryManagementSystem.UserControls
{
    public partial class BorrowCardUserControl : UserControl
    {

        private Image bookImage;
        private string bookTitle;
        private string firstName;
        private string lastName;
        private string courseCode;
        private string gender;
        private int borrowId;
        private int bookId;
        private int studentId;
        private DateTime dueDate;
        private DateTime borrowDate;
        private bool isInBorrowHistory = false;
        public BorrowCardUserControl()
        {
            InitializeComponent();
           
            if(IsInBorrowHistory == true) 
            { 
                delBtn.Visible = true;
                borrowState.Visible = false;
                returnBtn.Visible = false;
                editBtn.Visible = false;   
            }
            else
            {
                delBtn.Visible = false;
                borrowState.Visible = true;
                editBtn.Visible = true;
                returnBtn.Visible = true;
            }
        }

        public bool IsInBorrowHistory { get { return isInBorrowHistory; } set { isInBorrowHistory = value; } }

        public Image BookImage { get { return bookImage; } set { bookImage = value; bookPb.Image = value; } }


        public string BookTitle { get { return bookTitle; } set { bookTitle = value; bookTitleLbl.Text = value; } }

        public string FirstName { get { return firstName; } set { firstName = value;  } }


        public string LastName { get { return lastName; } set { lastName = value; } }

        public string CourseCode { get { return courseCode; } set { courseCode = value; courseCodeLbl.Text = value; } }

        public string Gender { get { return gender; } set { gender = value; genderLbl.Text = value; } }

        public int BorrowId { get { return borrowId; } set { borrowId = value; } }
        public int BookId { get { return bookId; } set { bookId = value; } }
        public int StudentId { get { return studentId; } set { studentId = value; } }
        public DateTime DueDate { get { return dueDate; } set { dueDate = value; dueDateLbl.Text = value.ToShortDateString(); } }
        public DateTime BorrowDate { get { return borrowDate; } set { borrowDate = value; borrowDateLbl.Text =  value.ToShortDateString(); } }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BorrowCardUserControl_Load(object sender, EventArgs e)
        {
            borrowerFNameLbl.Text = $"{FirstName} {LastName}";
            bool isOverDue = CheckIfBorrowDue(BorrowId);

            if (isOverDue == true)
            {
                borrowState.Text = "Overdue";
                borrowState.BackColor = Color.Red;
                borrowState.ForeColor = Color.White;
                borrowState.Padding = new Padding(3);
            }
            else
            {
                borrowState.Text = "On borrow";
                borrowState.BackColor = Color.Green;
                borrowState.ForeColor = Color.White;
                borrowState.Padding = new Padding(3);
            }

            if (IsInBorrowHistory == true)
            {
                delBtn.Visible = true;
                borrowState.Visible = false;
                returnBtn.Visible = false;
                editBtn.Visible = false;
            }
            else
            {
                delBtn.Visible = false;
                borrowState.Visible = true;
                editBtn.Visible = true;
                returnBtn.Visible = true;
            }
        }

        private void borrowDateLbl_Click(object sender, EventArgs e)
        {

        }

        private void bookTitleLbl_Click(object sender, EventArgs e)
        {

        }

        //return btn
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            BLL_Borrow bLL_Borrow = new BLL_Borrow();

                if (bLL_Borrow.UpdateBorrowState(BorrowId, "Returned", BookId))
                {
                    MessageBox.Show("Book returned sucessfully!");
                }
                else
                {
                    MessageBox.Show("An error occured.");
                }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            MakeBorrowForm makeBorrowForm = new MakeBorrowForm();
            makeBorrowForm.IsInEdit = true;

            string borrower = $"{FirstName} {LastName}";

            makeBorrowForm.UpdateEditFields(BorrowId, StudentId, BookId, BookTitle, borrower, DueDate, BorrowDate, BookImage);
            makeBorrowForm.ShowDialog();
        }

        public bool CheckIfBorrowDue(int borrowId)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) 
            {
                connection.connect.Open();
            }

            string query = "SELECT COUNT(*) FROM borrows WHERE borrow_id = @borrowId AND borrows.due_date < GETDATE()";

            SqlCommand command = new SqlCommand(query, connection.connect);
            command.Parameters.AddWithValue("@borrowId", borrowId);

            try
            {
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
            catch
            {
                throw;
            }
        }

        //delete btn 
        private void button1_Click(object sender, EventArgs e)
        {
            BLL_Borrow bLL_Borrow = new BLL_Borrow();

            DialogResult result = MessageBox.Show("Do you want to delete this in record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (bLL_Borrow.DeleteBorrow(BorrowId, bookId))
                {
                    MessageBox.Show("Deleted successfully");
                
                } else
                {
                    MessageBox.Show("An error occured while deleting");
                }
            }
               
        }
    }
}
