
namespace BotChallenge.DAL
{
    static class SQLColumns
    {
        public static class User
        {
            public static readonly string UserId = "@UserId";
            public static readonly string Login = "@Login";
            public static readonly string Password = "@Password";
            public static readonly string AccessToken = "@AccessToken";
        }
    }
}
