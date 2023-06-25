using CommunityToolkit.Mvvm.ComponentModel;

namespace FairyTalesApp.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy = false;
        [ObservableProperty]
        string title;
        public bool IsNotBusy => !IsBusy;


        public BaseViewModel()
        {
            SetProperty(ref isBusy, false);
        }
    }
}
