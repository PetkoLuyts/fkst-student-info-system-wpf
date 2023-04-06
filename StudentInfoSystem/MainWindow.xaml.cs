using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student();
            try
            {
                student.FirstName = firstNameTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : firstNameTextBox.Text;
                student.MiddleName = middleNameTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : middleNameTextBox.Text;
                student.LastName = lastNameTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : lastNameTextBox.Text;
                student.Faculty = facultyTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : facultyTextBox.Text;
                student.FacultyNumber = facultyNumberTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : facultyNumberTextBox.Text;
                student.Speciality = specialityTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : specialityTextBox.Text;
                student.Degree = degreeTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : degreeTextBox.Text;
                student.GroupNumber = int.Parse(groupTextBox.Text);
                student.Stream = int.Parse(streamTextBox.Text);
                student.Status = statusTextBox.Text == string.Empty ? throw new Exception("All fields must be filled out") : statusTextBox.Text;
                student.Course = int.Parse(courseTextBox.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                ClearFields();
            }


        }
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void toggleEnableButton_Click(object sender, RoutedEventArgs e)
        {
            bool isEnabled = !toggleEnableButton.Content.Equals("Disable");

            firstNameTextBox.IsEnabled = isEnabled;
            middleNameTextBox.IsEnabled = isEnabled;
            lastNameTextBox.IsEnabled = isEnabled;
            facultyTextBox.IsEnabled = isEnabled;
            facultyNumberTextBox.IsEnabled = isEnabled;
            specialityTextBox.IsEnabled = isEnabled;
            degreeTextBox.IsEnabled = isEnabled;
            groupTextBox.IsEnabled = isEnabled;
            streamTextBox.IsEnabled = isEnabled;
            statusTextBox.IsEnabled = isEnabled;
            courseTextBox.IsEnabled = isEnabled;

            toggleEnableButton.Content = isEnabled ? "Disable" : "Enable";
        }

        private void ClearFields()
        {
            firstNameTextBox.Text = string.Empty;
            middleNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
            facultyTextBox.Text = string.Empty;
            facultyNumberTextBox.Text = string.Empty;
            specialityTextBox.Text = string.Empty;
            degreeTextBox.Text = string.Empty;
            groupTextBox.Text = string.Empty;
            streamTextBox.Text = string.Empty;
            statusTextBox.Text = string.Empty;
            courseTextBox.Text = string.Empty;
        }
    }
}
