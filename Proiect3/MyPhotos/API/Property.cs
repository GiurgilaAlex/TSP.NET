using MyPhotos.API;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPhotos
{
    public partial class Property
    {
        public List<String> GetAllProperties()
        {
            List<String> propertyNames = new List<String>();

            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = @"Select DISTINCT [Key] From Properties";
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        propertyNames.Add(reader["Key"].ToString());
                    }
                }
            }

            return propertyNames;
        }

        public List<MyPhotos.Property> GetPropertiesByFileId(Guid fileId)
        {
            List<MyPhotos.Property> properties = new List<MyPhotos.Property>();

            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = @"Select Id, [Key], Value From Properties Where FileId = @FileId";
                sqlCommand.Parameters.Add("@FileId", System.Data.SqlDbType.UniqueIdentifier).Value = fileId;

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        MyPhotos.Property property = new MyPhotos.Property();

                        property.Id = reader.GetGuid(reader.GetOrdinal("Id"));
                        property.Key = reader["Key"].ToString();
                        property.Value = reader["Value"].ToString();

                        properties.Add(property);
                    }
                }
            }

            return properties;
        }

        public void Add(MyPhotos.Property property)
        {
            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "INSERT INTO Properties(Id,[Key],Value,FileId) VALUES(@Id,@Key,@Value,@FileId)";

                sqlCommand.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                sqlCommand.Parameters.Add("@Key", System.Data.SqlDbType.NVarChar).Value = property.Key;
                sqlCommand.Parameters.Add("@Value", System.Data.SqlDbType.NVarChar).Value = property.Value;
                sqlCommand.Parameters.Add("@FileId", System.Data.SqlDbType.UniqueIdentifier).Value = property.FileId;

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Update(MyPhotos.Property property)
        {
            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "UPDATE Properties SET [Key] = @Key, Value = @Value WHERE Id = @Id";
                sqlCommand.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = property.Id;
                sqlCommand.Parameters.Add("@Key", System.Data.SqlDbType.NVarChar).Value = property.Key;
                sqlCommand.Parameters.Add("@Value", System.Data.SqlDbType.NVarChar).Value = property.Value;

                sqlCommand.ExecuteNonQuery();
            }
        }

        public void Delete(Guid id)
        {
            using (SqlCommand sqlCommand = SqlServerDbConnection.Connection.CreateCommand())
            {
                sqlCommand.CommandText = "DELETE FROM Properties WHERE Id = @Id";
                sqlCommand.Parameters.Add("@Id", System.Data.SqlDbType.UniqueIdentifier).Value = id;

                sqlCommand.ExecuteNonQuery();
            }
        }

    }
}
