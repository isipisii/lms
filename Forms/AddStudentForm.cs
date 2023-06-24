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

namespace LibraryManagementSystem.View
{
    public partial class AddStudentForm : Form
    {       

        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            courseCmb.Items.Clear();

            // fetch the course names from the course table
            List<string> courseNames = FetchCourseNames();

           
            courseCmb.Items.AddRange(courseNames.ToArray());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }


        // for getting the courses to be populated in the combo box
        private List<string> FetchCourseNames()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT course_name FROM course";
            SqlCommand command = new SqlCommand(query, con.connect);

            List<string> courseNames = new List<string>();

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // retrieve the course name from the reader and add it to the list
                        string courseName = reader["course_name"].ToString();
                        courseNames.Add(courseName);
                    }
                }
            }
            catch
            {
                throw;
            }

            return courseNames;
        }

        //for adding the students in db
        private void s_Click(object sender, EventArgs e)
        {
            BLL_Students students = new BLL_Students();
            // get the course code base on the course name from combo box
            string courseCode = RetrieveCourseCode(courseCmb.SelectedItem.ToString());
            string gender = "";

            if (maleRdBtn.Checked)
            {
                gender = "Male";
            }

            if (femaleRdBtn.Checked)
            {
                gender = "Female";
            }

            if (firstnameTb.Text == "" || lastNameTb.Text == "" || emailTb.Text == "" || courseCode == "" || gender == "")
            {
                MessageBox.Show("Please fillout the fields!");

            }
            else
            {   
                if(students.CheckIfStudentExists(firstnameTb.Text, lastNameTb.Text))
                {
                    MessageBox.Show("This student is already existing!");
                } else
                {
                     if(students.AddStudent(firstnameTb.Text, lastNameTb.Text, courseCode, emailTb.Text, gender))
                    {
                        MessageBox.Show("Success!");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }
                }
            }
        }



        //for retrieving the coursecode that will become a foreign key
        public string RetrieveCourseCode(string courseName)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT course_code FROM course WHERE course_name = @courseName";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                command.Parameters.AddWithValue("@courseName", courseName);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader["course_code"].ToString();
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

        private void courseCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
