using MOV_FacturacionElectronica.ViewModels;
using MOV_FacturacionElectronica.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MOV_FacturacionElectronica
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
