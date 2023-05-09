using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand : ICommand
    {
        // the class is a command, that knows when to be called:

        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");
            NamesWindow namesWindow = new NamesWindow();
            namesWindow.ShowDialog();
        }
        public bool CanExecute(object parameter)    // the command is always available
        {
            return true;
        }
        // the event is not called manually
        public event EventHandler CanExecuteChanged;

    }
}
