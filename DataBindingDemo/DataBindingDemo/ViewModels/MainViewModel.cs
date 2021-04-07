using System.Threading.Tasks;
using System.Windows.Input;
using DataBindingDemo.Services;
using Xamarin.Forms;

namespace DataBindingDemo.ViewModels
{
    public class MainViewModel
    {
        private readonly INavigationService navigationService;
        private ICommand navigateToPageCommand;

        public MainViewModel(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public ICommand NavigateToPageCommand
        {
            get
            {
                return this.navigateToPageCommand ??
                       (this.navigateToPageCommand = new Command<string>(async (page) => await this.OnNavigateToPage(page)));
            }
        }

        private async Task OnNavigateToPage(string pageName)
        {
            await this.navigationService.PushAsync(pageName);
        }
    }
}
