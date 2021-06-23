using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADemo
{
    public class UserInfo
    {
        public static string lastname;
        public static string firstname;
        
    }
    //public  class DbConnection
    //{
    //    public SqlConnection sqlConnection = null;
    //    public  SqlConnection ConnectToDB()
    //    {
    //        if (sqlConnection == null)
    //        {
    //            string connectionstring = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
    //            sqlConnection = new SqlConnection(connectionstring);
    //        }
    //        return sqlConnection;
    //    }
    //}
}
