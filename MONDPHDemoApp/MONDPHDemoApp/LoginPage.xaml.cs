using Microsoft.AppCenter.Analytics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MONDPHDemoApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async Task Button_Clicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Login", new Dictionary<string, string> {
                { "Account", "Email" }
            });

            await Navigation.PushAsync(new MainPage());
        }

        private async Task Button_Clicked1(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Login", new Dictionary<string, string> {
                { "Account", "Microsoft" }
            });

            await Navigation.PushAsync(new MainPage());
        }

        private async Task Button_Clicked2(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Login", new Dictionary<string, string> {
                { "Account", "Facebook" }
            });

            await Navigation.PushAsync(new MainPage());
        }

        private async Task Button_Clicked3(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Login", new Dictionary<string, string> {
                { "Account", "Twitter" }
            });

            await Navigation.PushAsync(new MainPage());
        }
    }
}
