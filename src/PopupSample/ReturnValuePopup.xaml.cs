using Xamarin.CommunityToolkit.UI.Views;

namespace PopupSample
{
    public partial class ReturnValuePopup : Popup
    {
        public ReturnValuePopup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Dismiss("Hello from completed popup!");
        }

        protected override object GetLightDismissResult()
        {
            return "Closed popup via light dismiss or outside of popup";
        }
    }
}