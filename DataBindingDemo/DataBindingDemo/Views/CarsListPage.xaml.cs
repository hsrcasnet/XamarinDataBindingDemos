﻿using DataBindingDemo.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarsListPage : ContentPage
    {
        public CarsListPage()
        {
            this.InitializeComponent();
        }

        private async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is Car car)
            {
                await this.DisplayAlert("Car Tapped", $"{car} was tapped.", "OK");

                // Deselect Item
                ((ListView)sender).SelectedItem = null;
            }
        }
    }
}