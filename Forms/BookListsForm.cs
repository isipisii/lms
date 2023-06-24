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
    public partial class BookListsForm : Form
    {
        public BookListsForm()
        {   
            BLL_Book bLL_Book = new BLL_Book();

            InitializeComponent();
            GenerateBooks(bLL_Book.GetItems());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public void GenerateBooks(DataTable dataTable)
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
                            listItems[i].IsInForm = true;
                            bookListPanel.Controls.Add(listItems[i]);

                        }
                    }
                }
            }
        }

        private void BookListsForm_Load(object sender, EventArgs e)
        {

        }

    }
}
