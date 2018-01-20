using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotChallenge.DAL
{
    static class SQLQueries
    {
        public static class User
        {
            public static readonly string SELECT_BY_ID = "SELECT * FROM User WHERE UserId = @UserId;";
            public static readonly string INSERT_COMMAND = @" INSERT INTO User ( UserId, Login, Password, AccessToken ) VALUES ( @UserId, @Login, @Password, @AccessToken );";
            public static readonly string UPDATE_COMMAND = @" UPDATE User SET Login = @Login, Password = @Password, AccessToken = @AccessToken WHERE UserId = @UserId; ";
            public static readonly string DELETE_COMMAND = @" DELETE FROM User WHERE UserId = @UserId; ";
            public static readonly string LOGIN_USER_COMMAND = "SELECT * FROM User WHERE Login = @Login AND Password = @Password";
        }
    }
}
