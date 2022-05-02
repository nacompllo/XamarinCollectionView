using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinCollectionView.Models
{
    public class Bot : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                RaiseOnPropertyChanged();
            }
        }
    }
}