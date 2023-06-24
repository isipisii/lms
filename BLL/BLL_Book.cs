using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryManagementSystem.DAL;

namespace LibraryManagementSystem.BLL
{
    internal class BLL_Book
    {
        public bool SaveItems(string title, string author, int quantity, System.Drawing.Image image, string description)
        {
            try
            {
                DAL_Book book = new DAL_Book();
                return book.AddItemsToTable(title, author, quantity, image, description); // pass data to BOOK DAL

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool DeleteBook (int id)
        {
            try
            {
                DAL_Book book = new DAL_Book();
                return book.DeleteItemFromTable(id);

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetItems()
        {
            try
            {
                DAL_Book book = new DAL_Book();
                return book.ReadItemsTable(); // pass data to BOOK DAL

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public bool UpdateBook(int id, string title, string author, int quantity, System.Drawing.Image image, string description)
        {
            try
            {
                DAL_Book book = new DAL_Book();
                return book.UpdateItemInTable(id, title, author, quantity, image, description); // pass data to BOOK DAL

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetSearchedBook(string searchTerm)
        {
            try
            {
                DAL_Book book = new DAL_Book();
                return book.SearchBook(searchTerm);

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

    }
}
