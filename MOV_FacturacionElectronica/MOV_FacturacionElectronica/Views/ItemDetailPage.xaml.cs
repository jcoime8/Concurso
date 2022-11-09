using MOV_FacturacionElectronica.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MOV_FacturacionElectronica.Views
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