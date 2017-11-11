using HmhengXamBot.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HmhengXamBot
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HmhengXamBot.MainPage();
            this.MainPage = new WebPage { Title = "Web Page" };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
