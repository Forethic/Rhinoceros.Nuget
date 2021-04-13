using System;
using System.Windows.Input;

namespace Rhinoceros.MVVM
{
    /// <summary>
    /// 包含参数的RelayCommand
    /// </summary>
    public class ParamRelayCommand : ICommand
    {
        private Func<object, bool> _CanExecute;
        private Action<object> _Action;

        public ParamRelayCommand(Action<object> action) : this(action, null) { }

        public ParamRelayCommand(Action<object> action, Func<object, bool> canExecute)
        {
            _Action = action;
            _CanExecute = canExecute;
        }

        public event EventHandler CanExecuteChanged = delegate { };

        public bool CanExecute(object parameter)
        {
            if (_CanExecute != null) return _CanExecute(parameter);

            return true;
        }

        public void Execute(object parameter) => _Action(parameter);
    }
}