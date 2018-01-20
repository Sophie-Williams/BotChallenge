using BotChallenge.Shared;
using System.Configuration;
using System.Data.SqlClient;
using System;

namespace BotChallenge.DAL.Repositories
{
    class BaseRepository
    {
        protected string connectionString;

        public BaseRepository()
        {
            connectionString = ConfigurationManager.ConnectionStrings[Constants.ConnectionStringKey].ConnectionString;
        }

        protected void ExecuteCommand(Action<SqlCommand> commandInitializer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();
                commandInitializer(command);
                command.ExecuteNonQuery();
            }
        }
    }
}
