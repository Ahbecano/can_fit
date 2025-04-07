using System.ComponentModel;
using CanFitApp.ViewModels;
using Xamarin.Forms;

namespace CanFitApp.Views
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