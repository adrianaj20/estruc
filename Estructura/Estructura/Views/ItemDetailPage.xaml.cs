using Estructura.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Estructura.Views
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