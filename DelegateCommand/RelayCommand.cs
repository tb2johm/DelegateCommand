using System;
using System.Windows.Input;

namespace DelegateCommand
{
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
 
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            this._execute = execute;
            this._canExecute = canExecute ?? (() => true);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public event System.EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }
    }
}