using Check_In_App.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Check_In_App.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}