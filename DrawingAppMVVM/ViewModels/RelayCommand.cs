using System;
using System.Windows.Input;

namespace DrawingAppMVVM.ViewModels
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private readonly Action<object> _command;

        public RelayCommand(Action<object> command)
        {
            _command = command;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _command.Invoke(parameter);
        }
    }
}
