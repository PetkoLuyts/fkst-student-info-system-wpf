using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class LoginValidation
    {
        private string username;
        private string password;
        private string errorMessage;
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError actionOnError;

        public static UserRoles currentUserRole { get; private set; }
        public static UserRoles currentUserName { get; private set; }

        public LoginValidation(String username, String password, ActionOnError actionOnError)
        {
            this.username = username;
            this.password = password;
            this.actionOnError = new ActionOnError(actionOnError);
        }

        public bool ValidateUserInput(ref User user)
        {
            Boolean emptyUsername;
            emptyUsername = username.Equals(String.Empty);
            if (emptyUsername)
            {
                errorMessage = "Username is empty";
                actionOnError(errorMessage);
                return false;
            }

            Boolean emptyPassword;
            emptyPassword = password.Equals(String.Empty);
            if (emptyPassword)
            {
                errorMessage = "Password is empty";
                actionOnError(errorMessage);
                return false;
            }

            if (username.Length < 5)
            {
                errorMessage = "Username needs to be more than 5 characters";
                actionOnError(errorMessage);
                return false;
            }

            if (password.Length < 5)
            {
                errorMessage = "Password needs to be more than 5 characters";
                actionOnError(errorMessage);
                return false;
            }

            user = UserData.IsUserPassCorrect(username, password);
            if (user != null)
            {
                currentUserRole = (UserRoles)user.role;
                Logger.LogActivity("Successful login");
                return true;
            }
            else
            {
                errorMessage = "No such user found. Username/Password incorrect";
                actionOnError(errorMessage);
                return false;
            }

        }
    }
}
