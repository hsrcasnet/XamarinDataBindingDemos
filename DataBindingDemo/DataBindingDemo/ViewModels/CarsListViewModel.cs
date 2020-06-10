using System.Collections.ObjectModel;
using DataBindingDemo.Model;

namespace DataBindingDemo.ViewModels
{
    public class CarsListViewModel
    {
        public ObservableCollection<Car> Cars { get; set; }

        public CarsListViewModel()
        {
            this.Cars = new ObservableCollection<Car>
            {
                new Car
                {
                    Brand = "BWM",
                    Model = "X5"
                },
                new Car
                {
                    Brand = "Audi",
                    Model = "A4"
                },
            };
        }

    }
}