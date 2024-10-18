using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ContactList
{
    public class Connection
    {
        SqlConnection conn;
        public SqlConnection getCon()
        {
            conn = new SqlConnection("Data Source=localhost;Initial Catalog=Contacts;Integrated Security=True;Encrypt=False");
            return conn;
        }
    }
}
