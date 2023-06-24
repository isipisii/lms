using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DAL
{
    internal class Connection
    {
        public SqlConnection connect = new SqlConnection("Data Source=LAPTOP-DJTIC59U\\SQLEXPRESS01;Initial Catalog=LibraryMngmt;Integrated Security=True");
    }
}
