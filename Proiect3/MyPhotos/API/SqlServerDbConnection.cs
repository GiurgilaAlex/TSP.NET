using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.API
{
    class SqlServerDbConnection
    {
        private static SqlConnection _myConnection;
        public static SqlConnection Connection
        {
            get
            {
                if (_myConnection != null && _myConnection.State == System.Data.ConnectionState.Open)
                {
                    return _myConnection;
                }
                else
                {
                    return InitializeDbConnection();
                }
            }
        }

        private static SqlConnection InitializeDbConnection()
        {
            _myConnection = new SqlConnection();

            _myConnection.ConnectionString = "Data Source = DESKTOP-KOH6HHI\\SQLEXPRESS; Initial Catalog=MyFiles; Integrated Security=SSPI;";
            _myConnection.Open();

            return _myConnection;
        }
    }
}
