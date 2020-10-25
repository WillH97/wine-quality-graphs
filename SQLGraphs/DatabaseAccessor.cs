using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace DbUtils
{
    public class DatabaseAccessor
    {
        private SqlConnectionStringBuilder builder;

        public DatabaseAccessor()
        {
            this.builder = new SqlConnectionStringBuilder();
            builder.DataSource = "willholmes.database.windows.net";
            builder.UserID = "whserveradmin";
            builder.Password = "Coralblueno2";
            builder.InitialCatalog = "WineQuality";
        }

        public DatabaseAccessor(string servername, string username, string password, string dbname)
        {
            this.builder = new SqlConnectionStringBuilder();
            builder.DataSource = servername;
            builder.UserID = username;
            builder.Password = password;
            builder.InitialCatalog = dbname;
        }

        public List<SubjectEntry> BuildSubjectEntryList()
        {
            List<SubjectEntry> subjects = new List<SubjectEntry>();

            try
            {
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    string query = "SELECT * FROM winequalityred";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subjects.Add(new SubjectEntry(reader));
                            }
                        }
                    }
                }
            } 
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return subjects;
        }
    }
}