using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UserLogin;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for UserAndPassWindow.xaml
    /// </summary>
    public partial class UserAndPassWindow : Window
    {
        public string facultyNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private  LoginViewModel viewModel;

        public UserAndPassWindow(LoginViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            DataContext = viewModel;
        }

        private void loginButtonVerify_Click(object sender, RoutedEventArgs e)
        {
            // check if the user and password exist:
            // if exists, open dialog message
            // the window closes and goes back to the mainwindow
            // on return, display the student info n the main window

            if (usernameTextbox.Text == String.Empty || passwordTextbox.Text == String.Empty)
            {
                MessageBox.Show("Невалидна стойност.");
                return;
            }

            StudentInfoContext context = new StudentInfoContext();

            
            foreach (var user in context.Users)
            {
                
                if (user.username == usernameTextbox.Text && user.password == passwordTextbox.Text)
                {
                    //facultyNumber = user.number;
                    //Console.WriteLine(facultyNumber.ToString());
                    MessageBox.Show("Logged successfully");

                    viewModel.Username = usernameTextbox.Text;
                    viewModel.Password = passwordTextbox.Text;
                    viewModel.FacNum = user.number;

                    this.Close();
                    // return user's number --->>> later becomes faculty number and you search through the students by faculty nomber

                }
            }
            




        }
    }
}
