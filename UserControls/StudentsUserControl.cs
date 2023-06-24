using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.DAL;
using LibraryManagementSystem.UserControls;
using LibraryManagementSystem.View;

namespace LibraryManagementSystem
{
    public partial class StudentsUserControl : UserControl
    {
        public StudentsUserControl()
        {
            InitializeComponent();
            DisplayStudents();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddStudentForm addStudentForm = new AddStudentForm();   
            addStudentForm.ShowDialog();
        }

        private void studentsDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void DisplayStudents()
        {
            studentsFlowLayoutPanel.Controls.Clear();
            BLL_Students bLL_Students = new BLL_Students();

            DataTable data = bLL_Students.GetItems();
            RefreshData(data);
 
        }


        //refresh btn
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayStudents();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void RefreshData(DataTable dataTable)
        {
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    StudentCardUserControl[] listItems = new StudentCardUserControl[dataTable.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            listItems[i] = new StudentCardUserControl();

                            //get the other properties to be shown in usercontrol
                            listItems[i].FirstName = row["first_name"].ToString();
                            listItems[i].LastName = row["last_name"].ToString();
                            listItems[i].StudentId = (int)row["" +
                                "student_id"];
                            listItems[i].CourseCode = row["course_code"].ToString();
                            listItems[i].Email = row["email"].ToString();
                            listItems[i].Gender = row["gender"].ToString();
                            studentsFlowLayoutPanel.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void StudentsUserControl_Load(object sender, EventArgs e)
        { 

            // fetch the course names from the course table
            List<string> courseId = FetchCourseIds();


            filterCourseCmb.Items.AddRange(courseId.ToArray());
        }

        private List<string> FetchCourseIds()
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT course_code FROM course";
            SqlCommand command = new SqlCommand(query, con.connect);

            List<string> courseNames = new List<string>();

            try
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // retrieve the course name from the reader and add it to the list
                        string courseName = reader["course_code"].ToString();
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

        private void label6_Click(object sender, EventArgs e)
        {


        }

        private void filterCourseCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentsFlowLayoutPanel.Controls.Clear();
            string selectedCourse = filterCourseCmb.SelectedItem.ToString();

            if(selectedCourse == "All")
            {
                BLL_Students bLL_Students = new BLL_Students();

                DataTable data = bLL_Students.GetItems();
                RefreshData(data);
            }
            else RefreshData(FilterStudents(selectedCourse));
        }



        public DataTable FilterStudents(string searchTerm)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM students WHERE course_code LIKE @searchTerm OR gender LIKE @searchTerm";
            SqlCommand command = new SqlCommand(query, con.connect);
            command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentsFlowLayoutPanel.Controls.Clear();
           string  selectedGender = comboBox1.SelectedItem.ToString();

            if (selectedGender == "All")
            {
                BLL_Students bLL_Students = new BLL_Students();

                DataTable data = bLL_Students.GetItems();
                RefreshData(data);
            }
            else RefreshData(FilterStudents(selectedGender));
        }
    }
}
