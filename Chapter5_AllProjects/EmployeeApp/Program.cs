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

DateTime hireDateEmp3 = new DateTime(2020, 4, 8);
EmployeeWithProperties emp3 = new EmployeeWithProperties("Mark",45, 456, 30000, EmployeePayTypeEnum.Salaried, hireDateEmp3);
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

// Using pattern matching with EmployeePayTypeEnum (see switch statement)
DateTime hireDateEmp4 = new DateTime(2021, 3, 15);
EmployeeWithProperties emp4 = new EmployeeWithProperties("Jackson",45,123,1000,EmployeePayTypeEnum.Salaried, hireDateEmp4);
Console.WriteLine(emp4.Pay);
emp4.GiveBonus(100);
Console.WriteLine(emp4.Pay);

Console.ReadLine();