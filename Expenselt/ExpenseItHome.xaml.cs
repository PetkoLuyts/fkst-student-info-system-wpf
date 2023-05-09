using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Expenselt
{
    public partial class ExpenseItHome : Window, INotifyPropertyChanged
    {
        public List<Person> ExpenseDataSource { get; set; }
        //public DateTime LastChecked { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;    // delegate
        public ObservableCollection<string> PersonsChecked { get; set; }

        private DateTime lastChecked;
        public DateTime LastChecked
        {
            get { return lastChecked; }
            set
            {
                lastChecked = value;
                // Извикване на PropertyChanged
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("LastChecked"));
            }
        }



        public ExpenseItHome()
        {
            InitializeComponent();
            LastChecked = DateTime.Now;
            this.DataContext = this;
            PersonsChecked = new ObservableCollection<string>();
            // ObservableCollection
            ExpenseDataSource = new List<Person>()
            {
                new Person()
                {
                    Name="Lalo",
                    Department ="Legal",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Lunch", ExpenseAmount =50 },
                        new Expense() { ExpenseType="Transportation", ExpenseAmount=50 }
                    }
                },
                new Person()
                {
                    Name ="Mukta",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Document printing", ExpenseAmount=50 },
                        new Expense() { ExpenseType="Gift", ExpenseAmount=125 }
                    }
                },
                new Person()
                {
                    Name="Indra",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Magazine subscription", ExpenseAmount=50 },
                        new Expense() { ExpenseType="New machine", ExpenseAmount=600 },
                        new Expense() { ExpenseType="Software", ExpenseAmount=500 }
                    }
                },
                new Person()
                {
                    Name="Lorena",
                    Department ="Finance",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                    }
                },
                new Person()
                {
                    Name="Mara",
                    Department ="Marketing",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Dinner", ExpenseAmount=100 }
                    }
                },
                new Person()
                {
                    Name="James",
                    Department ="Sales",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Lunch", ExpenseAmount=40 },
                        new Expense() { ExpenseType="Travel", ExpenseAmount=150 }
                    }
                },
                new Person()
                {
                    Name="Akuchi",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Software", ExpenseAmount=250 }
                    }
                },
                new Person()
                {
                    Name="Ikaros",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Software", ExpenseAmount=250 }
                    }
                },
                new Person()
                {
                    Name="Ode",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Software", ExpenseAmount=250 }
                    }
                },
                new Person()
                {
                    Name="Nobuko",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Software", ExpenseAmount=250 }
                    }
                },
                new Person()
                {
                    Name="Ode",
                    Department ="Engineering",
                    Expenses = new List<Expense>()
                    {
                        new Expense() { ExpenseType="Software", ExpenseAmount=250 }
                    }
                }
            };
        }

        

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReport = new ExpenseReport(this.peopleListBox.SelectedItem);
            expenseReport.Height = this.Height;
            expenseReport.Width = this.Width;
            expenseReport.ShowDialog();
        }

        private void peopleListBox_SelectionChanged_1(object sender,SelectionChangedEventArgs e)
        {
            LastChecked = DateTime.Now;
            //PersonsChecked.Add(peopleListBox.SelectedItem.ToString());
            PersonsChecked.Add((peopleListBox.SelectedItem as System.Xml.XmlElement).Attributes["Name"].Value);
        }
    }
}
