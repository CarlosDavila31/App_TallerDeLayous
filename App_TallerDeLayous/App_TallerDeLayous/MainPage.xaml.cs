using App_TallerDeLayous.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_TallerDeLayous
{   
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Flyout = new PrincipalPage();

            this.Detail = new NavigationPage(new DetallePage())
            {
                BarBackgroundColor = Color.DarkBlue
            };

            App.FlyoutP = this;
        }
    }
}
