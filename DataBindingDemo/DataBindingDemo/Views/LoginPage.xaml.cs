using DataBindingDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DataBindingDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}