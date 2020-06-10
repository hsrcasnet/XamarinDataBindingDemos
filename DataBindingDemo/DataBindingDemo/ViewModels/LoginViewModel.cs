using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DataBindingDemo.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string username;
        private string password;
        private bool acceptTermsAndConditions;

        public string Username
        {
            get => this.username;
            set
            {
                this.username = value;
                this.OnPropertyChanged(nameof(this.Username));
            }
        }

        public string Password
        {
            get => this.password;
            set
            {
                this.password = value;
                this.OnPropertyChanged(nameof(this.Password));
            }
        }

        public bool AcceptTermsAndConditions
        {
            get => this.acceptTermsAndConditions;
            set
            {
                this.acceptTermsAndConditions = value;
                this.OnPropertyChanged(nameof(this.AcceptTermsAndConditions));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}