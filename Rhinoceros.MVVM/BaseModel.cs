using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Rhinoceros.MVVM
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        protected void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged(this, e);

        public void RaisePropertyChanged([CallerMemberName] string propertyName = null) => OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

        public bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) return false;

            field = value;
            RaisePropertyChanged(propertyName);
            return true;
        }
    }
}