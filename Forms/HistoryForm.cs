using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.UserControls;

namespace LibraryManagementSystem.Forms
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {   
           
            InitializeComponent();
            GenerateBorrowsData(new BLL_Borrow().GetReturnedBorrows());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        public void GenerateBorrowsData(DataTable dataTable)
        {
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    BorrowCardUserControl[] listItems = new BorrowCardUserControl[dataTable.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            listItems[i] = new BorrowCardUserControl();

                            //reconverting binary formatted from db
                            string imageBase64 = row["image"].ToString();

                            byte[] imageData = Encoding.Default.GetBytes(imageBase64);

                            MemoryStream memoryStream = new MemoryStream(imageData);
                            listItems[i].BookImage = new Bitmap(memoryStream);

                            //get the other properties to be shown in usercontrol
                            listItems[i].BookTitle = row["title"].ToString();
                            listItems[i].FirstName = row["first_name"].ToString();
                            listItems[i].LastName = row["last_name"].ToString();
                            listItems[i].BorrowId = (int)row["borrow_id"];
                            listItems[i].CourseCode = row["course_code"].ToString();
                            listItems[i].Gender = row["gender"].ToString();

                            listItems[i].BorrowDate = Convert.ToDateTime(row["borrow_date"]).Date;
                            listItems[i].DueDate = Convert.ToDateTime(row["due_date"]).Date;
                            listItems[i].BookId = (int)row["book_id"];
                            listItems[i].StudentId = (int)row["student_id"];
                            listItems[i].IsInBorrowHistory = true;
                            flowLayoutPanel1.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            GenerateBorrowsData(new BLL_Borrow().GetReturnedBorrows());
        }
    }
}
