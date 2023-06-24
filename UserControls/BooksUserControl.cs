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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LibraryManagementSystem
{
    public partial class BooksUserControl : UserControl
    {

        public BooksUserControl()
        {
            InitializeComponent();
            GenerateDynamicUserControl();
        }

        // open add form
        private void button1_Click(object sender, EventArgs e)
        {
           AddBookForm addBookForm = new AddBookForm();
           addBookForm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void titleTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void RefreshData(DataTable dataTable)
        {
            if (dataTable != null)
            {
                if (dataTable.Rows.Count > 0)
                {
                    BookCardUserControl1[] listItems = new BookCardUserControl1[dataTable.Rows.Count];

                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            listItems[i] = new BookCardUserControl1();

                            //reconverting binary formatted from db
                            string imageBase64 = row["image"].ToString(); // Assuming the value is stored as a base64 encoded string

                            byte[] imageData = Encoding.Default.GetBytes(imageBase64);

                            MemoryStream memoryStream = new MemoryStream(imageData);
                            listItems[i].Image = new Bitmap(memoryStream);

                            //get the other properties to be shown in usercontrol
                            listItems[i].Title = row["title"].ToString();
                            listItems[i].Author = row["author"].ToString();
                            listItems[i].Quantity = (int)row["" +
                                "quantity"];
                            listItems[i].Id = (int)row["book_id"];
                            listItems[i].Description = row["book_desc"].ToString();
                            flowLayoutPanel1.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        public void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            RefreshData(new BLL_Book().GetItems());

        }

        //refresh btn
        private void button5_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BooksUserControl_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }

        // for book search
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear(); // Clear existing controls
            RefreshData(new BLL_Book().GetSearchedBook(searchBox.Text.Trim()));
        }

        //add btn
        private void pictureBox1_Click(object sender, EventArgs e)
        {
             AddBookForm addBookForm = new AddBookForm();
            addBookForm.ShowDialog();
        }

        //refresh btn
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();

        }
    }
}
