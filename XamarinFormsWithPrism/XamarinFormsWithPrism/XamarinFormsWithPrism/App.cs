using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XamarinFormsWithPrism.Common;

namespace XamarinFormsWithPrism
{
    public class App : Application
    {
        public Bootstrapper Bootstrapper { get; set; }
        public App()
        {
            // The root page of your application
            Bootstrapper = new Bootstrapper();
            Bootstrapper.Run(this);
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
