using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ScrollView_Keybrd_ScrollY_Bug_iOS
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

