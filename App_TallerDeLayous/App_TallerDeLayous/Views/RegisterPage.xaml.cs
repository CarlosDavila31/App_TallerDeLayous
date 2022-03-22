using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_TallerDeLayous.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }        

        private void btnRegister_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
            //Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}