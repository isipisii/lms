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
using LibraryManagementSystem.UserControls;

namespace LibraryManagementSystem.Forms
{
    public partial class StudentListsForm : Form
    {
        public StudentListsForm()
        {   
            BLL_Students bLL_Students = new BLL_Students();
            InitializeComponent();
            GenerateData(bLL_Students.GetItems());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentListsForm_Load(object sender, EventArgs e)
        {

        }

        public void GenerateData(DataTable dataTable)
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
                            listItems[i].IsInForm = true;
                            studentListPanel.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }
    }
}
