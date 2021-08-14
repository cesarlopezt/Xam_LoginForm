using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginForm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnLoginClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                await DisplayAlert("Error", "Username shouldn't be empty!", "Ok");
            } 
            else if (string.IsNullOrEmpty(password.Text)) 
            {
                await DisplayAlert("Error", "Password shouldn't be empty", "Ok");
            }
            else
            {
                await DisplayAlert("Welcome back", $"Hi {username.Text}!", "Ok");
            }
        }
    }
}
