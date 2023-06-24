using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.DAL;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LibraryManagementSystem.BLL
{
    internal class BLL_Students
    {
        public bool AddStudent(string firstName, string lastName, string courseCode, string email, string gender)
        {
            try
            {
                DAL_Student student = new DAL_Student();
                return student.AddStudentsToTable(firstName, lastName, courseCode, gender, email); // pass data to Student DAL

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                DAL_Student student = new DAL_Student();
                return student.DeleteStudentFromTable(id);

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
                DAL_Student student = new DAL_Student();
                return student.ReadItemsTable(); // pass data to BOOK DAL

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return null;
            }
        }

        //TODO
        public bool UpdateStudent(int studentId, string firstName, string lastName, string email, string courseCode ,string gender)
        {
            try
            {
                DAL_Student dAL_Student = new DAL_Student(); 
                return dAL_Student.UpdateItemInTable(studentId, firstName, lastName, email, courseCode, gender);
                    // pass data to BOOK DAL

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }

        //check if student already exists
       public bool CheckIfStudentExists(string firstName, string lastName)
        {
            try
            {
                DAL_Student dAL_Student = new DAL_Student();
                return dAL_Student.CheckIfStudentExists(firstName, lastName);
             

            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show(e.Message.ToString());
                return false;
            }
        }
    }
}
