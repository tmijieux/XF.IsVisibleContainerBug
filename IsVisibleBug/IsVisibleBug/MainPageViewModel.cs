using System.Windows.Input;
using Xamarin.Forms;

namespace IsVisibleBug
{
    public class MainPageViewModel : BaseViewModel
    {
        private string theText = "short";
        public string TheText
        {
            get => theText;
            set => this.RaiseAndSetIfChanged(ref theText, value);
        }

        private bool containerVisible = true;
        public bool ContainerVisible
        {
            get => containerVisible;
            set => this.RaiseAndSetIfChanged(ref containerVisible, value);
        }


        public ICommand HideContainer { get; } 
        public ICommand ShowContainer { get; } 
        public ICommand MakeTextShort { get; }
        public ICommand MakeTextLong { get; }


        public MainPageViewModel()
        {
            HideContainer = new Command(() => ContainerVisible = false);
            ShowContainer = new Command(() => ContainerVisible = true);
            MakeTextShort = new Command(() => TheText = "short");
            MakeTextLong = new Command(() => TheText = "long long long long");
        }
    }
}