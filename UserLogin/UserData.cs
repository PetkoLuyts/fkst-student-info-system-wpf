using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static List<User> testUsers;

        public static List<User> TestUsers
        {
            get
            {
                ResetTestUserData();
                return testUsers;
            }
            set
            {

            }
        }

        private static void ResetTestUserData()
        {
            if (testUsers == null)
            {
                testUsers = new List<User>(3);

                User user1 = new User("Petko", "123456", "121220186", 1);
                user1.created = DateTime.Now;
                user1.expire = DateTime.MaxValue;
                testUsers.Add(user1);

                User user2 = new User("Gosho", "pass", "121220199", 4);
                user2.created = DateTime.Now;
                user2.expire = DateTime.MaxValue;
                testUsers.Add(user2);

                User user3 = new User("Pesho", "password", "121220133", 4);
                user3.created = DateTime.Now;
                user3.expire = DateTime.MaxValue;
                testUsers.Add(user3);
            }
        }

        public static User IsUserPassCorrect(String username, String password)
        {
            User searchedUser = TestUsers.Where(u => u.username.Equals(username) && u.password.Equals(password)).First();

            return searchedUser;
        }

        public static void SetUserActiveTo(string username, DateTime setActivityDate)
        {
            foreach (var user in TestUsers)
            {
                if (user.username.Equals(username))
                {
                    user.expire = setActivityDate;
                    Logger.LogActivity("Change of activity to: " + username);
                }
            }
        }

        public static void AssignUserRole(string username, UserRoles updateRole)
        {
            foreach (var user in TestUsers)
            {
                if (user.username.Equals(username))
                {
                    user.role = (int)updateRole;
                    Logger.LogActivity("Change of role to: " + username);
                }
            }
        }
    }
}
