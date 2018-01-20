using System.Data.SqlClient;

namespace BotChallenge.Shared
{
    public class User
    {

        public User() { }

        public User(SqlDataReader reader)
        {
            UserId = (string)reader["UserId"];
            Login = (string)reader["Login"];
            Password = (string)reader["Password"];
            AccessToken = (string)reader["AccessToken"];
        }

        public string UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string AccessToken { get; set; }
    }
}
