using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleContent.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private async void SignBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NewEmail.Text) || string.IsNullOrEmpty(NewUser.Text) || string.IsNullOrEmpty(NewPass.Text) || string.IsNullOrEmpty(ConfirmPass.Text))
            {
                await DisplayAlert("Mensaje", "Campos Vacios", "Ok");
            }
            else
            {
                if (ConfirmPass.Text != NewPass.Text)
                {
                    await DisplayAlert("Mensaje", "La contraseña no coincide", "Ok");
                }
                else
                {
                    await DisplayAlert("Bienvenido", $"Registrado {NewUser.Text}", "Ok");
                    NewPass.Text = string.Empty;
                    NewEmail.Text = string.Empty;
                    NewUser.Text = string.Empty;
                    ConfirmPass.Text = string.Empty;
                }
            }
        }

        //private async void SignUp_Clicked(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(NewEmail.Text) || string.IsNullOrEmpty(NewUser.Text) || string.IsNullOrEmpty(NewPass.Text) || string.IsNullOrEmpty(ConfirmPass.Text))
        //    {
        //        await DisplayAlert("Mensaje", "Campos Vacios", "Ok");
        //    }
        //    else
        //    {
        //        if (ConfirmPass.Text != NewPass.Text)
        //        {
        //            await DisplayAlert("Mensaje", "La contraseña no coincide", "Ok");
        //        }
        //        else
        //        {
        //            await DisplayAlert("Bienvenido", $"Registrado {NewUser.Text}", "Ok");
        //            NewPass.Text = string.Empty;
        //            NewEmail.Text = string.Empty;
        //            NewUser.Text = string.Empty;
        //            ConfirmPass.Text = string.Empty;
        //        }
        //    }
        //}
    }
}