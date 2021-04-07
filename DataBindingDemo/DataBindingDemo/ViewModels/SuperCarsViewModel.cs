using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DataBindingDemo.Model;
using Xamarin.Forms;

namespace DataBindingDemo.ViewModels
{
    public class SuperCarsViewModel : INotifyPropertyChanged
    {
        public string Title { get; } = "Super Cars";

        public ObservableCollection<CarViewModel> Cars { get; }

        public ICommand UpdateCarCommand { get; }

        public SuperCarsViewModel()
        {
            this.UpdateCarCommand = new Command(() => this.UpdateCar());

            var cars = new List<Car>
            {  
                new Car
                {
                    Brand = "Lamborghini",
                    Model = "Aventador SVJ"
                },
                new Car
                {
                    Brand = "McLaren",
                    Model = "720S"
                }
            };

            var carViewModels = cars.Select(c => new CarViewModel(c));

            this.Cars = new ObservableCollection<CarViewModel>(carViewModels);
        }

        private void UpdateCar()
        {
            this.Cars[0].Brand = "Ferrari";
            this.Cars[0].Model = "488 Pista";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}