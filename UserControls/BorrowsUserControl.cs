using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.BLL;
using LibraryManagementSystem.Forms;
using LibraryManagementSystem.UserControls;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagementSystem
{
    public partial class BorrowsUserControl : UserControl
    {
        public BorrowsUserControl()
        {
            BLL_Borrow bLL_Borrow = new BLL_Borrow();
            InitializeComponent();
            RefreshBorrows();
        }


        // make borrow button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MakeBorrowForm makeBorrowForm = new MakeBorrowForm();
            makeBorrowForm.ShowDialog();
        }

        private void BorrowsUserControl_Load(object sender, EventArgs e)
        {

        }

        public void RefreshBorrows()
        {
            borrowsFlowLayoutPanel.Controls.Clear();
            GenerateBorrowsData(new BLL_Borrow().GetBorrows());
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
                           
                            borrowsFlowLayoutPanel.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void borrowsFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {   
           
            RefreshBorrows();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.ShowDialog();
        }
    }
}
