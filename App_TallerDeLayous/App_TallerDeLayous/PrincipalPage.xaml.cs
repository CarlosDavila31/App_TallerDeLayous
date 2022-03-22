using App_TallerDeLayous.Views;
using App_TallerDeLayous.ViewsModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_TallerDeLayous
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalPage : ContentPage
    {
        public ObservableCollection<MenuClass> Menuclass { get; set; }

        public PrincipalPage()
        {
            InitializeComponent();
            Menuclass = new ObservableCollection<MenuClass>()
            {
               
                new MenuClass
                {
                     Tittle ="#2",
                     ButtonText ="Ir a top Cars",
                     Text ="Información de top Cars",
                     Pagina = new Page6()
                },
                new MenuClass
                {
                     Tittle ="FRIENDS FREED",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new Page1()
                },
                new MenuClass
                {
                     Tittle ="WRITE POST",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new Page2()
                },
                new MenuClass
                {
                     Tittle ="MUSIC TRACKS",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new Page3()
                },
                new MenuClass
                {
                     Tittle ="MUSIC PLAYER",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new Page4()
                },

                new MenuClass
                {
                     Tittle ="ACCOUNT SETTINGS  ",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new Page5()
                },

                  new MenuClass
                {
                     Tittle ="ACCOUNT  ",
                     ButtonText ="Ir a Acercar",
                     Text ="Información Acercar",
                     Pagina = new calendarioxaml()
                },

            };

            this.BindingContext = this;
        }
        
        private void Button_Clicked(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page1());
            App.FlyoutP.IsPresented = false;
        }

        private void Button_Clicked2(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page2());
            App.FlyoutP.IsPresented = false;
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new Page3());
            App.FlyoutP.IsPresented = false;
        }

        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MenuClass element = (MenuClass)e.CurrentSelection.FirstOrDefault();
            GoToPage(element.Pagina);

        }

        private async void GoToPage(Page page)
        {
            await App.FlyoutP.Detail.Navigation.PushAsync(page);
            App.FlyoutP.IsPresented = false;
        }
        
    }
}