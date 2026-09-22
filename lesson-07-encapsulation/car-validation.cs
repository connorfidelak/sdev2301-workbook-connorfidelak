class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the name of your car: ");
        string CarInput = Console.ReadLine() ?? "";
        Console.WriteLine();

        Console.WriteLine("Enter the model of your car: ");
        string ModelInput = Console.ReadLine() ?? "";
        Console.WriteLine();

        Console.WriteLine("Enter your speed: ");
        int SpeedInput = int.Parse(Console.ReadLine() ?? "");
        Console.WriteLine();

        try
        {
            Car car = new Car(CarInput, ModelInput, SpeedInput);
            Console.WriteLine($"Your {car.Name} {car.Model} is going {car.Speed} km/h!");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    class Car
    {
        public string Name { get; }
        public string Model { get; }
        private int _speed;
        public int Speed
        {
            get => _speed;
            set
            {
                if (value < 0 || value > 200)
                    throw new ArgumentOutOfRangeException(nameof(value), "Speed has to be between 0 and 200.");
                _speed = value;
            }
        }

        public Car(string name, string model, int speed)
        {
            Name = name;
            Model = model;
            Speed = speed;
        }
    }
}