namespace DataBindingDemo.Model
{
    public class Car
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public override string ToString()
        {
            return $"{{{this.Brand} {this.Model}}}";
        }
    }
}