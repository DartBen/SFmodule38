using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HomeApp.Pages;

namespace HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ProfilePage();//new RegisterPage();//new DevicesPage();// new LoginPage();// new CsharpPaddingPage(); //new LoginPage();
            //new RoomsPage(); //new RegisterPage(); //new LoginPage(); // new LoadingPage(); new MainPage();
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
