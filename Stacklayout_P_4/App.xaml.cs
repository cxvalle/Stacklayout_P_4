using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Stacklayout_P_4.views;

namespace Stacklayout_P_4
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Pagina();
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
