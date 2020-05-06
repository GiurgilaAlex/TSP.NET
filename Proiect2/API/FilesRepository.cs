using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos.API
{
    public class FilesRepository
    {
        private const string _sqlGetAllFiles = @"Select Id, Name, Path From Files";

        public void Delete(Guid id)
        {
            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "DELETE FROM Properties WHERE FileId = @Id";
                sqlCommand.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = id;
                sqlCommand.ExecuteNonQuery();

                sqlCommand.CommandText = "DELETE FROM Files WHERE Id = @Id";
                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Update(File file)
        {
            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "UPDATE Files SET Name = @Name, Path = @Path WHERE Id = @Id";
                sqlCommand.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = file.Id;
                sqlCommand.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = file.Name;
                sqlCommand.Parameters.Add("@Path", System.Data.SqlDbType.NVarChar).Value = file.Path;

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Add(File file)
        {
            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "INSERT INTO Files(Id,Name,Path) VALUES(@param1,@param2,@param3)";

                sqlCommand.Parameters.Add("@param1", System.Data.SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                sqlCommand.Parameters.Add("@param2", System.Data.SqlDbType.NVarChar).Value = file.Name;
                sqlCommand.Parameters.Add("@param3", System.Data.SqlDbType.NVarChar).Value = file.Path;

                sqlCommand.ExecuteNonQuery();
            }
        }

        public List<File> GetAllFiles()
        {
            List<File> files = new List<File>();

            using(SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = _sqlGetAllFiles;
                using(SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        File file = new File();

                        file.Id = reader.GetGuid(reader.GetOrdinal("Id"));
                        file.Name = reader["Name"].ToString();
                        file.Path = reader["Path"].ToString();

                        files.Add(file);
                    }
                }
            }

            return files;
        }
        public List<File> GetFilesByProperty(string key, string value)
        {
            List<File> files = new List<File>();

            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = @"Select f.* From Properties p join Files f On p.FileId=f.Id Where p.[Key] =@Key AND p.[Value] =@Value";
                sqlCommand.Parameters.Add("@Key", System.Data.SqlDbType.NVarChar).Value = key;
                sqlCommand.Parameters.Add("@Value", System.Data.SqlDbType.NVarChar).Value = value;

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        File file = new File();

                        file.Id = reader.GetGuid(reader.GetOrdinal("Id"));
                        file.Name = reader["Name"].ToString();
                        file.Path = reader["Path"].ToString();

                        files.Add(file);
                    }
                }
            }

            return files;
        }
    }
}
