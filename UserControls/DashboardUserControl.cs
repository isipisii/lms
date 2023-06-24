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

namespace LibraryManagementSystem
{
    public partial class DashboardUserControl : UserControl
    {
        public DashboardUserControl()
        {
            InitializeComponent();
            RenderDashboardData();
        }

        private void RenderDashboardData()
        {   
            upcomingDuesFlowlayoutPanel.Controls.Clear();
            BLL_Borrow bLL_Borrow = new BLL_Borrow();
            int borrowersCount = CountBorrowersInTable();
            int overDuesCount = CountOverDuesInTable();
            int borrowedBooks = CountBorrowedBooksInTable();

            borrowersCountLbl.Text = borrowersCount.ToString();
            overDuesLbl.Text = overDuesCount.ToString();
            borrowedBooksCount.Text = borrowedBooks.ToString();

            RefreshData(bLL_Borrow.GetUpcomingBorrows());
        }
        private void label1_Click(object sender, EventArgs e)
        { 
        }
       


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void borrowedBooksCount_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void RefreshData(DataTable dataTable)
        {
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    UpcomingDuesUserControl[] listItems = new UpcomingDuesUserControl[dataTable.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            listItems[i] = new UpcomingDuesUserControl();

                            //reconverting binary formatted from db
                            string imageBase64 = row["image"].ToString(); // Assuming the value is stored as a base64 encoded string

                            byte[] imageData = Encoding.Default.GetBytes(imageBase64);

                            MemoryStream memoryStream = new MemoryStream(imageData);
                            listItems[i].BookImage = new Bitmap(memoryStream);

                            //get the other properties to be shown in usercontrol
                            listItems[i].FirstName = row["first_name"].ToString();
                            listItems[i].LastName = row["last_name"].ToString();
                            listItems[i].BookTitle = row["title"].ToString();

                            listItems[i].DueDate = Convert.ToDateTime(row["due_date"]).Date;
                           
                            upcomingDuesFlowlayoutPanel.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        //get over dues
        public int CountOverDuesInTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State)
            {
                connection.connect.Open();
            }

            string query = "SELECT COUNT(*) FROM borrows WHERE borrows.due_date < GETDATE() AND state is NULL";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                int count = (int)command.ExecuteScalar();
                return count;
            }
            catch
            {
                throw;
            }
        }

        // get borrowers count
        public int CountBorrowersInTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State)
            {
                connection.connect.Open();
            }

            string query = "SELECT COUNT(DISTINCT student_id) FROM borrows WHERE state is NULL"; 
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                int count = (int)command.ExecuteScalar();
                return count;
            }
            catch
            {
                throw;
            }
        }

        public int CountBorrowedBooksInTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State)
            {
                connection.connect.Open();
            }

            string query = "SELECT COUNT(book_id) FROM borrows WHERE state is NULL";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                int count = (int)command.ExecuteScalar();
                return count;
            }
            catch
            {
                throw;
            }
        }

        private void DashboardUserControl_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {   
            RenderDashboardData();
        }
    }
}
