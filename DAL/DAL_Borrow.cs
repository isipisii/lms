using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Net;

namespace LibraryManagementSystem.DAL
{
    internal class DAL_Borrow
    {

        // add to book table
        public bool AddBorrowsToTable(int studentId, int bookId, DateTime borrowDate,  DateTime dueDate)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }
            string borrowQuery = "INSERT INTO borrows(student_id, book_id, borrow_date, due_date) VALUES (@studentId, @bookId, @borrowDate, @dueDate)";
            string updateQuantityQuery = "UPDATE books SET quantity = quantity - 1 WHERE book_id = @bookId";

            SqlTransaction transaction = null;
            try
            {

                using (SqlCommand borrowCommand = new SqlCommand(borrowQuery, connection.connect))
                {
                    borrowCommand.Parameters.AddWithValue("@studentId", studentId);
                    borrowCommand.Parameters.AddWithValue("@bookId", bookId);
                    borrowCommand.Parameters.AddWithValue("@borrowDate", borrowDate);
                    borrowCommand.Parameters.AddWithValue("@dueDate", dueDate);

                    transaction = connection.connect.BeginTransaction();

                    borrowCommand.Transaction = transaction;
                    borrowCommand.ExecuteNonQuery(); // save borrow to table

                    using (SqlCommand updateQuantityCommand = new SqlCommand(updateQuantityQuery, connection.connect))
                    {
                        updateQuantityCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateQuantityCommand.Transaction = transaction;
                        updateQuantityCommand.ExecuteNonQuery(); // update book quantity
                    }

                    transaction.Commit();
                }

                return true;
            }
            catch
            {
                transaction?.Rollback();
                throw;
            }
        }

        public DataTable ReadBorrowsTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT students.*, books.*, borrows.* FROM borrows INNER JOIN students ON borrows.student_id = students.student_id INNER JOIN books ON borrows.book_id = books.book_id WHERE state is NULL;";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable); // save all the records coming from the database
                    return dataTable;
                }
            }
            catch
            {
                throw;
            }
        }

        public DataTable ReadReturnedBorrowsTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT students.*, books.*, borrows.* FROM borrows INNER JOIN students ON borrows.student_id = students.student_id INNER JOIN books ON borrows.book_id = books.book_id WHERE state = 'Returned'";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable); // save all the records coming from the database
                    return dataTable;
                }
            }
            catch
            {
                throw;
            }
        }

        public bool DeleteBorrowFromTable(int borrowId, int bookId)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "DELETE FROM borrows WHERE borrow_id = @borrowId";

            SqlTransaction transaction = null;
            try
            {
                using (SqlCommand borrowCommand = new SqlCommand(query, connection.connect))
                {   
                    borrowCommand.Parameters.AddWithValue("@borrowId", borrowId);

                    // return true if at least one row is affected, indicating successful deletion

                    transaction = connection.connect.BeginTransaction();

                    borrowCommand.Transaction = transaction;
                    borrowCommand.ExecuteNonQuery(); // save borrow to table

                    transaction.Commit();
                }

                return true;
            }
            catch
            {
                transaction?.Rollback();
                throw;
            }
        }


        // update borrow
        public bool UpdateBorrowInTable(int borrowId, int bookId, int studentId, DateTime borrowDate, DateTime dueDate)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State)
            {
                connection.connect.Open();
            }

            string query = "UPDATE borrows SET book_id = @bookId, student_id = @studentId, borrow_date = @borrowDate, due_date = @dueDate WHERE borrow_id = @borrowId";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection.connect))
                {
                    command.Parameters.AddWithValue("@borrowId", borrowId);
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.Parameters.AddWithValue("@studentId", studentId);
                    command.Parameters.AddWithValue("@borrowDate", borrowDate);
                    command.Parameters.AddWithValue("@dueDate", dueDate);

                    int rowsAffected = command.ExecuteNonQuery(); // execute the update command

                    // return true if at least one row is affected, indicating successful update
                    return rowsAffected > 0;
                }
            }
            catch
            {
                throw;
            }
        }

        public bool UpdateBorrowStateInTable(string state, int borrowId, int bookId)
        {

            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "UPDATE borrows SET state = @state WHERE borrow_id = @borrowId";
            string updateQuantityQuery = "UPDATE books SET quantity = quantity + 1 WHERE book_id = @bookId";

            SqlTransaction transaction = null;
            try
            {
                using (SqlCommand borrowCommand = new SqlCommand(query, connection.connect))
                {
                    borrowCommand.Parameters.AddWithValue("@borrowId", borrowId);
                    borrowCommand.Parameters.AddWithValue("@state", state);

                    // return true if at least one row is affected, indicating successful deletion

                    transaction = connection.connect.BeginTransaction();

                    borrowCommand.Transaction = transaction;
                    borrowCommand.ExecuteNonQuery(); // save borrow to table

                    using (SqlCommand updateQuantityCommand = new SqlCommand(updateQuantityQuery, connection.connect))
                    {
                        updateQuantityCommand.Parameters.AddWithValue("@bookId", bookId);
                        updateQuantityCommand.Transaction = transaction;
                        updateQuantityCommand.ExecuteNonQuery(); // update book quantity
                    }

                    transaction.Commit();
                }

                return true;
            }
            catch
            {
                transaction?.Rollback();
                throw;
            }
        }


        public bool CheckIfBorrowInTable(int studentId, int bookId)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT COUNT(*) FROM borrows WHERE student_id = @studentId AND book_id = @bookId AND state is NULL";

            SqlCommand command = new SqlCommand(query, connection.connect);
            command.Parameters.AddWithValue("@studentId", studentId);
            command.Parameters.AddWithValue("@bookId", bookId);

            try
            {
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }  
            catch
            {
                throw;
            }
        }
        public DataTable ReadUpcomingBorrowsTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT borrows.due_date, books.image, students.first_name, students.last_name, books.title FROM borrows INNER JOIN students ON borrows.student_id = students.student_id INNER JOIN books ON borrows.book_id = books.book_id WHERE state is NULL AND DATEDIFF(day, CAST(GETDATE() AS DATE), CAST(due_date AS DATE)) >= 1 AND DATEDIFF(day, CAST(GETDATE() AS DATE), CAST(due_date AS DATE)) <= 3";
            SqlCommand command = new SqlCommand(query, connection.connect);

            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable); // save all the records coming from the database
                    return dataTable;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
