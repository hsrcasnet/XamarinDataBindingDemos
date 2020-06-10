using DataBindingDemo.Views;
using Xamarin.Forms;

namespace DataBindingDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // DEMO Data Binding Basics
            MainPage = new NavigationPage(new LoginPage());

            // DEMO Relative Bindings
            //MainPage = new NavigationPage(new SliderPage());

            // DEMO Collection Bindings
            //MainPage = new NavigationPage(new CarsListPage());
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
