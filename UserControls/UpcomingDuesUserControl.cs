using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem.UserControls
{
    public partial class UpcomingDuesUserControl : UserControl
    {
        private string firstName;
        private string lastName;
        private DateTime dueDate;

        public Image BookImage
        {   
            get { return bookPb.Image; }
            set { bookPb.Image = value; }
        }

        public string FirstName {  get{ return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }

        public string BookTitle { get { return bookTitleLbl.Text; } set { bookTitleLbl.Text = value; } }

        public DateTime DueDate { get { return dueDate; } set { dueDate = value; dueDateLbl.Text = value.ToShortDateString(); } }

        public UpcomingDuesUserControl()
        {
            InitializeComponent();
            borrowerLbl.Text = $"{FirstName} {LastName}";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void UpcomingDuesUserControl_Load(object sender, EventArgs e)
        {
            borrowerLbl.Text = $"{FirstName} {LastName}";
        }

        private void borrowerLbl_Click(object sender, EventArgs e)
        {

        }

        private void bookTitleLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
