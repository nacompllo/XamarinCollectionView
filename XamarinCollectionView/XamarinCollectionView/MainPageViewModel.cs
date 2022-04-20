using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using XamarinCollectionView.Models;

namespace XamarinCollectionView
{
    public class MainPageViewModel
    {
        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaiseOnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private ObservableCollection<Bot> _bots = new ObservableCollection<Bot>();
        public ObservableCollection<Bot> Bots
        {
            get => _bots;
            set
            {
                _bots = value;
                RaiseOnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            for (var i = 0; i < 9999; i++)
            {
                Bots.Add(new Bot
                {
                    Name = $"Bot {i}"
                });
            }
        }
    }
}