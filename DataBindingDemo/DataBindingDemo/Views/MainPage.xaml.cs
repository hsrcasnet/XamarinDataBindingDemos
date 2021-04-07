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
            this.BindingContext = new MainViewModel(new NavigationService(this));
        }
    }
}