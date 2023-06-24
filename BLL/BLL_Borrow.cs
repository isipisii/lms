using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL;
using System.Windows.Forms;
using System.Data;
using System.Net;

namespace LibraryManagementSystem.BLL
{
    internal class BLL_Borrow
    {
        public bool MakeBorrow(int studentId, int bookId, DateTime borrowDate,  DateTime dueDate)
        {
            try
            {
                DAL_Borrow dAL_Borrow = new DAL_Borrow();
                return dAL_Borrow.AddBorrowsToTable(studentId, bookId, borrowDate, dueDate); 
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool UpdateBorrow(int borrowId ,int studentId, int bookId, DateTime borrowDate, DateTime dueDate)
        {
            try
            {
                DAL_Borrow dAL_Borrow = new DAL_Borrow();
                return dAL_Borrow.UpdateBorrowInTable(borrowId, bookId, studentId, borrowDate, dueDate);

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool UpdateBorrowState(int borrowId, string state, int bookId)
        {
            try
            {
                DAL_Borrow dAL_Borrow = new DAL_Borrow();
                return dAL_Borrow.UpdateBorrowStateInTable(state, borrowId, bookId);

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool DeleteBorrow(int borrowId, int bookId)
        {
            try
            {
                DAL_Borrow dAL_Borrow = new DAL_Borrow();
                return dAL_Borrow.DeleteBorrowFromTable(borrowId, bookId);

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetBorrows()
        {
            try
            {
                DAL_Borrow borrow = new DAL_Borrow();
                return borrow.ReadBorrowsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public bool CheckBorrowsIfExist(int studentId, int bookId)
        {
            try
            {
                DAL_Borrow dAL_Borrow=new DAL_Borrow();
                return dAL_Borrow.CheckIfBorrowInTable(studentId, bookId);
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public DataTable GetUpcomingBorrows()
        {
            try
            {
                DAL_Borrow dAL_Borrow = new DAL_Borrow();
                return dAL_Borrow.ReadUpcomingBorrowsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        public DataTable GetReturnedBorrows()
        {
            try
            {
                DAL_Borrow dAL_Borrow = new DAL_Borrow();
                return dAL_Borrow.ReadReturnedBorrowsTable();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
    }
}
