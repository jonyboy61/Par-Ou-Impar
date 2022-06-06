using AppNumeroImpar.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppNumeroImpar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PageInicial());
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
