using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Check_In_App.ViewModels
{
    public class CheckInModel : BaseViewModel
    {
        public CheckInModel()
        {
            Title = "CheckIn";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}