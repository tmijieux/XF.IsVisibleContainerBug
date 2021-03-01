using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace IsVisibleBug
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName]string propertyName=null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void RaiseAndSetIfChanged<T>(ref T backingField, T value, [CallerMemberName]string propertyName=null)
        {
            if (!backingField.Equals(value))
            {
                backingField = value;
                OnPropertyChanged(propertyName);
            }
        }
    }
}