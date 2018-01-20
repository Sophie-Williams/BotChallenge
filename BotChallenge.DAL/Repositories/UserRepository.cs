using BotChallenge.Shared;
using System.Data.SqlClient;
using BotChallenge.DAL.Prototypes;

namespace BotChallenge.DAL.Repositories
{
    class UserRepository : BaseRepository, IUserRepository
    {
        public void Add(User item)
        {
            ExecuteCommand((command) => { 
                command.CommandText = SQLQueries.User.INSERT_COMMAND;

                command.Parameters.Add(new SqlParameter(SQLColumns.User.UserId, item.UserId));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.Login, item.Login));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.Password, item.Password));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.AccessToken, item.AccessToken));
            });
        }

        public void Delete(string id)
        {
            ExecuteCommand((command) => { 

                command.CommandText = SQLQueries.User.DELETE_COMMAND;
                command.Parameters.Add(new SqlParameter(SQLColumns.User.UserId, id));
            });
        }

        public User Get(string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();

                command.CommandText = SQLQueries.User.SELECT_BY_ID;
                command.Parameters.Add(new SqlParameter(SQLColumns.User.UserId, id));

                SqlDataReader reader = command.ExecuteReader();

                return reader.Read() ? new User(reader) : null;
            }
        }

        public User Login(string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = connection.CreateCommand();

                command.CommandText = SQLQueries.User.LOGIN_USER_COMMAND;

                command.Parameters.Add(new SqlParameter(SQLColumns.User.Login, login));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.Password, password));

                SqlDataReader reader = command.ExecuteReader();

                return reader.Read() ? new User(reader) : null;
            }
        }

        public void Update(User item)
        {
            ExecuteCommand((command) => {
                command.CommandText = SQLQueries.User.UPDATE_COMMAND;

                command.Parameters.Add(new SqlParameter(SQLColumns.User.UserId, item.UserId));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.Login, item.Login));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.Password, item.Password));
                command.Parameters.Add(new SqlParameter(SQLColumns.User.AccessToken, item.AccessToken));
            });
        }
    }
}
