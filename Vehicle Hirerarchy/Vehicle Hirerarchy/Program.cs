
class Vehicle
{
    public string Brand {  get; set; }
    public int Year { get; set; }

    public Vehicle(string brand ,  int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }

}

class Car : Vehicle
{
 public int NumberOfDoors { get; set; }

    public Car(string brand , int year , int numberOfDoors) : base (brand , year)
    {
        NumberOfDoors = numberOfDoors;  
    }

}

class Bus : Vehicle
{
    public int Capacity { get; set; }

    public Bus (string brand , int year , int capacity) : base(brand, year)
    {
        Capacity = capacity;
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public Motorcycle (string brand , int year , bool hassidecar) : base (brand , year)
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("BMW", 2026, 2);
        Console.WriteLine("Brand Car is :" + car1.Brand);
        car1.Start();

        Console.WriteLine("--------------");

        Bus bus1 = new Bus("TOYOTA", 2026, 3);
        Console.WriteLine("Brand Bus is :" + bus1.Brand);
        bus1 .Start();

        Console.WriteLine("--------------");

        Motorcycle motorcycle1 = new Motorcycle("SUZUKI", 2026, false);
        Console.WriteLine("Brand Motorcycle is :" + motorcycle1.Brand);
        motorcycle1 .Start();




    }
}           

