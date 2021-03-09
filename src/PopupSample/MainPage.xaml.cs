using System;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace PopupSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.ShowPopup(new HelloPopup());
        }
    }
}
