using SampleContent.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleContent
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void SignBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
        }

        private async void LoginBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntUserName.Text) || string.IsNullOrEmpty(EntPass.Text))
            {
                await DisplayAlert("Error", "Campos Vacios", "ok");
            }
            else
            {
                await Navigation.PushAsync(new ContentMenu(EntUserName.Text));
            }
        }
    }
}
