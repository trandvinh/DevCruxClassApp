using DevCruxClassApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DevCruxClassApp.Views
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