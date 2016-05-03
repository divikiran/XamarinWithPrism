using Prism.Mvvm;
using Xamarin.Forms;
using XamarinFormsWithPrism.ViewModels;

namespace XamarinFormsWithPrism.Views
{
    public class Home : ContentPage
    {
        public Home()
        {
            SetValue(ViewModelLocator.AutowireViewModelProperty, true);
            
            var label = new Label { Text = "Hello ContentPage" };
            label.SetBinding<HomeViewModel>(Label.TextProperty, v => v.Name);
            Content = new StackLayout
            {
                Children = {
                    label
                }
            };
        }
    }
}
