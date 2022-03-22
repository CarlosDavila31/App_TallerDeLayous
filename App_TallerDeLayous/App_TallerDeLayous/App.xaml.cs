using App_TallerDeLayous.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_TallerDeLayous
{
    public partial class App : Application
    {
        public static FlyoutPage FlyoutP { get; set; }
        public App()
        {
            InitializeComponent();
           // MainPage = new MainPage();
            MainPage = new LoginPage();
           // MainPage = new RegisterPage();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
