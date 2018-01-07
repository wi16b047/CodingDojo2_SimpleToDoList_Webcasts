using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleToDoList.Commands
{
    class RelayCommand : ICommand
    {
        //public event EventHandler CanExecuteChanged; -> remove > ICommand > add interface explicitly

        private Action execute;
        private Func<bool> canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute) //delegates: void-method with no parameters 
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        //ICommand > add interface explicitly
        event EventHandler ICommand.CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value; //if it's not suggested I have to remove my registration
            }
        }

        public bool CanExecute(object parameter)
        {
            return canExecute();
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}
