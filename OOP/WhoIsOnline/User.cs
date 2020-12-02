using System;

namespace OOP.WhoIsOnline
{
    public class User
    {
        public string Username { get; private set; }
        public int LastActivity { get; private set; }
        public bool IsExistConnection { get; private set; }
        public UserStatus Status => GetStatus();

        public User(string username, bool isExistConnection, int lastActivity)
        {
            Username = username;
            IsExistConnection = isExistConnection;
            LastActivity = lastActivity;
        }

        private UserStatus GetStatus()
        {
            if (LastActivity >= 10)
                return UserStatus.Away;
            else if (IsExistConnection == true)
                return UserStatus.Online;
            else
                return UserStatus.Offline;
        }
    }
}
