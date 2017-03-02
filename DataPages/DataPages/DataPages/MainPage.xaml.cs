using System;
using Xamarin.Forms;

namespace DataPages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void DataPagesDefaultClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListDataDefaultPage());
        }

        private async void DataPagesCustomClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListDataCustomPage());
        }
    }
}
