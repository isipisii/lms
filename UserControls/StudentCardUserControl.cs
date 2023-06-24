using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL;
using LibraryManagementSystem.Forms;

namespace LibraryManagementSystem.UserControls
{
    public partial class StudentCardUserControl : UserControl
    {
        public StudentCardUserControl()
        {
            InitializeComponent();
        }

        private int studentId;
        private string firstName;
        private string lastName;
        private string email;
        private string gender;
        private string courseCode;
        private bool isInForm = false;


        public bool IsInForm { get { return isInForm; } set { isInForm = value; } }
        public int StudentId { get { return studentId; } set { studentId = value;  } }
        public string FirstName { get { return firstName; } set { firstName = value; firstNameLbl.Text = value; } }
        public string LastName { get { return lastName; } set { lastName = value; lastNameLbl.Text = value; } }
        public string Email { get { return email; } set {  email = value; emailLbl.Text = value;  } }
        public string Gender { get {  return gender; } set {  gender = value; genderLbl.Text = value; } }
        public string CourseCode { get {  return courseCode; } set {  courseCode = value; courseCodeLbl.Text = value; } }


        private void StudentCardUserControl_Load(object sender, EventArgs e)
        {
            if(isInForm == true)
            {
                editPicBox.Visible = false;
                deletePicBox.Visible = false;
                selectBtn.Visible = true;
            }
            else
            {
                editPicBox.Visible = true;
                deletePicBox.Visible = true;
                selectBtn.Visible = false;
            }
        }

        private void deletePicBox_Click(object sender, EventArgs e)
        {
            BLL_Students bLL_Students = new BLL_Students();

            DialogResult result = MessageBox.Show("Do you want to delete this in record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                if (bLL_Students.DeleteStudent(StudentId))
                {
                    MessageBox.Show("Deleted!");
                } 
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void editPicBox_Click(object sender, EventArgs e)
        {
            EditStudentForm editStudentForm = new EditStudentForm();

            //retrieved coursename based on course code
            string courseName = RetrieveCourseName(CourseCode);

            editStudentForm.UpdateFields(StudentId ,FirstName, LastName, Email, courseName, Gender);
            editStudentForm.ShowDialog();
        }

        public string RetrieveCourseName(string courseCode)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT course_name FROM course WHERE course_code = @courseCode";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                command.Parameters.AddWithValue("@courseCode", courseCode);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["course_name"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed!" + ex.Message);
                throw;
            }
            finally
            {
                // Ensure the connection is closed after the operation is complete
                connection.connect.Close();
            }

            // Return an empty string if the course code is not found
            return string.Empty;
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            MakeBorrowForm makeBorrowForm = Application.OpenForms.OfType<MakeBorrowForm>().FirstOrDefault();
            string borrowerFn = $"{FirstName} {LastName}";

            if (makeBorrowForm != null)
            {
                makeBorrowForm.UpdateBorrowerLabels(borrowerFn, StudentId);
            }
            else
            {
                makeBorrowForm = new MakeBorrowForm();
                makeBorrowForm.UpdateBorrowerLabels(borrowerFn, StudentId);
                makeBorrowForm.Show();
            }

            StudentListsForm studentListForm = Application.OpenForms.OfType<StudentListsForm>().FirstOrDefault();
            if (studentListForm != null)
            {
                studentListForm.Close();
            }
        }
    }
}
