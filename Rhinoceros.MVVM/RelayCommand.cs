using System;
using System.Windows.Input;

namespace Rhinoceros.MVVM
{
    public class RelayCommand : ICommand
    {
        private readonly Action _Action;

        public RelayCommand(Action action)
        {
            _Action = action;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => _Action();
    }
}