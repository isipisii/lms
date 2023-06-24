using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL
{
    internal class DAL_Student
    {

        public bool AddStudentsToTable(string firstName, string lastName, string courseCode, string gender, string email)
        {
            Connection connection = new Connection(); // con class created in DAL

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "INSERT INTO students(first_name, last_name, course_code, email, gender) VALUES (@firstName, @lastName, @courseCode, @email, @gender)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection.connect))
                {
                    command.Parameters.AddWithValue("@firstName", firstName.Trim());
                    command.Parameters.AddWithValue("@lastName", lastName.Trim());
                    command.Parameters.AddWithValue("@courseCode", courseCode.Trim());
                    command.Parameters.AddWithValue("@email", email.Trim());
                    command.Parameters.AddWithValue("@gender", gender.Trim());

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

            string query = "SELECT * FROM students";
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
        public bool DeleteStudentFromTable(int studentId)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "DELETE FROM students WHERE student_id = @studentId";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection.connect))
                {
                    command.Parameters.AddWithValue("@studentId", studentId);
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
        public bool UpdateItemInTable(int studentId, string firstName, string lastName, string email, string courseCode, string gender)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "UPDATE students SET first_name = @firstName, last_name = @lastName, email = @email, course_code = @courseCode, gender = @gender WHERE student_id = @studentId";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection.connect))
                {
                    command.Parameters.AddWithValue("@firstName", firstName.Trim());
                    command.Parameters.AddWithValue("@lastName", lastName.Trim());
                    command.Parameters.AddWithValue("@email", email.Trim());
                    command.Parameters.AddWithValue("@courseCode", courseCode.Trim());
                    command.Parameters.AddWithValue("@gender", gender.Trim());
                    command.Parameters.AddWithValue("@studentId", studentId);

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


        public bool CheckIfStudentExists(string firstName, string lastName)
        {
            Connection connection = new Connection();

            if (ConnectionState.Closed == connection.connect.State) // check if closed, and if it's closed, open the connection
            {
                connection.connect.Open();
            }

            string query = "SELECT COUNT(*) FROM students WHERE first_name = @firstName AND last_name = @lastName";

            SqlCommand command = new SqlCommand(query, connection.connect);
            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);

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
    }
}

