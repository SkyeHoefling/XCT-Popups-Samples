using System;
using System.Threading.Tasks;
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            // uncomment the different types of popups
            HelloPopup();

            // PositionPopup();
            // await ReturnValuePopup();
            // await GenericTypePopup();
        }

        void HelloPopup() => Navigation.ShowPopup(new HelloPopup());
        void PositionPopup() => Navigation.ShowPopup(new PositionPopup());
        async Task ReturnValuePopup()
        {
            object result = await Navigation.ShowPopupAsync(new ReturnValuePopup());
            await DisplayAlert("Popup Response", $"{result}", "OK");
        }

        async Task GenericTypePopup()
        {
            var result = await Navigation.ShowPopupAsync(new GenericValuePopup());
            await DisplayAlert(result.Title, result.Message, result.Ok);
        }
    }
}
