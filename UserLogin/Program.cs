using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        public static void DispayErrorMessage(string error)
        {
            Console.WriteLine("!!! " + error + " !!!");
        }

        public static UserRoles FindRole(string roleInput)
        {
            roleInput = roleInput.ToUpper();

            int numericValue;
            bool isNumber = int.TryParse(roleInput, out numericValue);

            if (isNumber)
            {
                switch (numericValue)
                {
                    case 0:
                        return UserRoles.ANONYMOUS;
                    case 1:
                        return UserRoles.ADMIN;
                    case 2:
                        return UserRoles.INSPECTOR;
                    case 3:
                        return UserRoles.PROFESSOR;
                    case 4:
                        return UserRoles.STUDENT;
                    default:
                        throw new ArgumentException("No such role");
                }
            }
            else
            {
                switch (roleInput)
                {
                    case "ANONYMOUS":
                        return UserRoles.ANONYMOUS;
                    case "ADMIN":
                        return UserRoles.ADMIN;
                    case "INSPECTOR":
                        return UserRoles.INSPECTOR;
                    case "PROFESSOR":
                        return UserRoles.PROFESSOR;
                    case "STUDENT":
                        return UserRoles.STUDENT;
                    default:
                        throw new ArgumentException("No such role");
                }
            }
        }

        public static void ChangeRoleOfUser()
        {
            Console.WriteLine("Username to change the role of: ");
            String username = Console.ReadLine();
            Console.WriteLine("Input the role: ");
            String role = Console.ReadLine();
            UserRoles userRole = FindRole(role);

            UserData.AssignUserRole(username, userRole);
        }

        public static void ChangeActivityExpiryDate()
        {
            Console.WriteLine("Username to change the activity expiry date of: ");
            String usernameToChangeExpDate = Console.ReadLine();
            Console.WriteLine("Input the expiry date: ");
            DateTime expiryDate = DateTime.Parse(Console.ReadLine());

            UserData.SetUserActiveTo(usernameToChangeExpDate, expiryDate);
        }

        public static void ListUsers()
        {
            foreach (var user in UserData.TestUsers)
            {
                Console.WriteLine(user.ToString() + "\n");
            }
        }

        public static void DisplayLogActivity()
        {
            String filePath = "/Users/macbook/Downloads/PS_44_Petko/UserLogin/test.txt";
            StreamReader sr = new StreamReader(filePath, true);

            if (File.Exists(filePath))
            {
                Console.WriteLine(sr.ReadToEnd());
            }

            sr.Close();
        }

        public static void DisplayCurrentActivity()
        {
            Console.WriteLine("Enter a filter: ");
            string filter = Console.ReadLine();
            IEnumerable<string> currentSessionActivities = Logger.GetCurrentSessionActivities(filter);
            StringBuilder sb = new StringBuilder();

            sb.Append("Current session activities: ");

            foreach (var activity in currentSessionActivities)
            {
                sb.Append(activity + " ");
            }

            Console.WriteLine(sb.ToString());
        }

        public static void DisplayMenuForAdmin()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("0: For exit");
            Console.WriteLine("1: Change the role of the user");
            Console.WriteLine("2: Change the activity expiry date of the user");
            Console.WriteLine("3: List of users");
            Console.WriteLine("4: Display log activity");
            Console.WriteLine("5: Display current activity");

            int userCommand = int.Parse(Console.ReadLine());

            switch (userCommand)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    ChangeRoleOfUser();
                    break;
                case 2:
                    ChangeActivityExpiryDate();
                    break;
                case 3:
                    ListUsers();
                    break;
                case 4:
                    DisplayLogActivity();
                    break;
                case 5:     
                    DisplayCurrentActivity();
                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter username");
            String username = Console.ReadLine();
            Console.WriteLine("Enter password");
            String password = Console.ReadLine();

            LoginValidation loginValidation = new LoginValidation(username, password, DispayErrorMessage);
            User user = new User();

            if (loginValidation.ValidateUserInput(ref user))
            {
                if (user.role == 1)
                {
                    DisplayMenuForAdmin();
                }

                Console.WriteLine(user.username);
                Console.WriteLine(user.password);
                Console.WriteLine(user.facultyNumber);
                Console.WriteLine(user.role);
                Console.WriteLine(user.expire);

                switch (LoginValidation.currentUserRole)
                {
                    case UserRoles.ANONYMOUS:
                        Console.WriteLine("User's role is: anonymous");
                        break;
                    case UserRoles.ADMIN:
                        Console.WriteLine("User's role is: admin");
                        break;
                    case UserRoles.INSPECTOR:
                        Console.WriteLine("User's role is: inspector");
                        break;
                    case UserRoles.PROFESSOR:
                        Console.WriteLine("User's role is: professor");
                        break;
                    case UserRoles.STUDENT:
                        Console.WriteLine("User's role is: student");
                        break;
                    default:
                        Console.WriteLine("User role error");
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
