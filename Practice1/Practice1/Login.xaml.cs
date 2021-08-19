using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practice1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
    
        }

        async private void OnButtonClicked(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(username.Text) || String.IsNullOrWhiteSpace(password.Text))
            {
                await DisplayAlert("Error", "Please fill all the fields", "OK");
            }
            else
            {
                await DisplayAlert("Welcome", $"Hello, {username.Text}", "OK");
            }
        }
    }
}