using DataBindingDemo.Services;
using DataBindingDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Demo: Manually create instance of MainViewModel and all its dependencies.
            //       Is there a better way to connect a Page with its ViewModel?
            this.BindingContext = new MainViewModel(new NavigationService(this));
        }
    }
}