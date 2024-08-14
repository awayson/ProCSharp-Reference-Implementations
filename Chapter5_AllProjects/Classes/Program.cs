using Classes;

Console.WriteLine("**** Fun with Class Types ****\n");

// Invoke the default constructor
Car chuck = new Car();
chuck.PrintState();

Motorcycle mc = new Motorcycle();
mc.PopAWheely();

Motorcycle c = new Motorcycle(5);
c.SetDriverName("Tiny");
c.PopAWheely();
Console.WriteLine("Rider name is {0}", c.name); // Prints empty value when name = name;

// Constructor chaining example
MotorcycleChaining d = new MotorcycleChaining(5);
d.SetDriverName("Larry");
d.PopAWheely();
Console.WriteLine("Rider name is {0}", d.name);

// Constructor with Optional Args
MotorcycleOptionalArgs m1 = new MotorcycleOptionalArgs();
Console.WriteLine("Name = {0}, Intensity = {1}", m1.name, m1.driverIntensity);

MotorcycleOptionalArgs m2 = new MotorcycleOptionalArgs(name:"Tiny");
Console.WriteLine("Name = {0}, Intensity = {1}", m2.name, m2.driverIntensity);

MotorcycleOptionalArgs m3 = new MotorcycleOptionalArgs(7);
Console.WriteLine("Name = {0}, Intensity = {1}", m3.name, m3.driverIntensity);


// Invoking overloaded constructor
Car mary = new Car("Mary");
mary.PrintState();
Car daisy = new Car("Daisy", 75);
daisy.PrintState();

Console.WriteLine("\n");

// Allocate and configure a Car object.
Car myCar = new Car();
myCar.petName = "Henry";
myCar.currSpeed = 10;

for (int i = 0; i < 10; i++)
{
    myCar.speedUp(5);
    myCar.PrintState();
}
Console.ReadLine();