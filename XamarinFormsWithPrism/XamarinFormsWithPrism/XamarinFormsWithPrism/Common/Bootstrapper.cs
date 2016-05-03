using System;
using Prism.Unity;
using Xamarin.Forms;
using Microsoft.Practices.Unity;
using XamarinFormsWithPrism.ViewModels;
using XamarinFormsWithPrism.Views;

namespace XamarinFormsWithPrism.Common
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override Page CreateMainPage()
        {
            return Container.Resolve<Home>();
        }

        protected override void RegisterTypes()
        {
            Container.RegisterType<HomeViewModel>();
        }
    }
}
