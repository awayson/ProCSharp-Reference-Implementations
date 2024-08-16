using EmployeeApp;

Console.WriteLine("**** Fun with Encapsulation ****\n");

Employee emp = new Employee("Marvin", 456, 30_000);
emp.GiveBonus(1000);
emp.DisplayStats();

// get/set Usage
emp.SetName("Marv");
Console.WriteLine("Employee is named: {0}", emp.GetName());

Employee emp2 = new Employee();
emp2.SetName("Xena the warrior princess");


EmployeeWithProperties emp3 = new EmployeeWithProperties("Mark", 456, 30000);
emp3.GiveBonus(1000);
emp3.DisplayStats();

emp3.Name = "Marky";
Console.WriteLine("Employee is named {0}", emp3.Name);

// Using implicit operators of c# to operate on types in properties
Employee joe = new Employee();

// Don't have to do this:
// joe.SetAge(joe.GetAge() + 1);

// With empAge encapsulated using a property, you can simply write
joe.Age++;

Console.ReadLine();