using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinCollectionView.Models;

namespace XamarinCollectionView
{
    public class MainPageViewModel : INotifyPropertyChanged
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

        private bool _defaultItemTemplateEnabled;
        public bool DefaultItemTemplateEnabled
        {
            get => _defaultItemTemplateEnabled;
            set
            {
                _defaultItemTemplateEnabled = value;
                RaiseOnPropertyChanged();
            }
        }

        public ICommand ChangeItemTemplateCommand => new Command(() => ChangeItemTemplate());

        public MainPageViewModel()
        {
            for (var i = 0; i < 10; i++)
            {
                Bots.Add(new Bot
                {
                    Name = $"Bot {i}"
                });
            }
        }

        private void ChangeItemTemplate()
        {
            DefaultItemTemplateEnabled = !DefaultItemTemplateEnabled;
        }
    }
}