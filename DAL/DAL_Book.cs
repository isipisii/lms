using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryManagementSystem.DAL
{
    internal class DAL_Book
    {
        // add to book table
        public bool AddItemsToTable(string title, string author, int quantity, System.Drawing.Image image, string description)
        {
            Connection connection = new Connection(); // con class created in DAL

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "INSERT INTO books(title, author, quantity, image, book_desc) VALUES (@title, @author, @quantity, @image, @description)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection.connect))
                {
                    command.Parameters.AddWithValue("@title", title.Trim());
                    command.Parameters.AddWithValue("@author", author.Trim());
                    command.Parameters.AddWithValue("@description", description.Trim());
                    command.Parameters.AddWithValue("@quantity", quantity);

                    // convert image into binary to be able to store in the database
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, image.RawFormat);
                    command.Parameters.AddWithValue("@image", memoryStream.ToArray());

                    command.ExecuteNonQuery(); // save to table
                }
                return true;
            }
            catch
            {
                throw;
            }
        }

        // get items from book table
        public DataTable ReadItemsTable()
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT * FROM books";
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

        // delete item from book table
            public bool DeleteItemFromTable(int bookId)
            {
                Connection connection = new Connection();

                if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
                {
                    connection.connect.Open();
                }

                string query = "DELETE FROM books WHERE book_id = @bookId";

                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection.connect))
                    {
                        command.Parameters.AddWithValue("@bookId", bookId);
                        int rowsAffected = command.ExecuteNonQuery(); // execute the delete command

                        // return true if at least one row is affected, indicating successful deletion
                        return rowsAffected > 0;
                    }
                }
                catch
                {
                    throw;
                }
            }

    
        // update item in book table
        public bool UpdateItemInTable(int bookId, string title, string author, int quantity, System.Drawing.Image image, string description)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "UPDATE books SET title = @title, author = @author, quantity = @quantity, image = @image, book_desc = @description WHERE book_id = @bookId";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection.connect))
                {
                    command.Parameters.AddWithValue("@bookId", bookId);
                    command.Parameters.AddWithValue("@title", title.Trim());
                    command.Parameters.AddWithValue("@author", author.Trim());
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@description", description.Trim());

                    // convert image into binary to be able to store in the database
                    MemoryStream memoryStream = new MemoryStream();
                    image.Save(memoryStream, image.RawFormat);
                    command.Parameters.AddWithValue("@image", memoryStream.ToArray());

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

        // for search
        public DataTable SearchBook(string searchTerm)
        {
            Connection con = new Connection();
            if (ConnectionState.Closed == con.connect.State)
            {
                con.connect.Open();
            }

            string query = "SELECT * FROM books WHERE title LIKE @searchTerm OR author LIKE @searchTerm";
            SqlCommand command = new SqlCommand(query, con.connect);
            command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

            try
            {
                using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                {
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    return dt;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}