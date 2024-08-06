Console.WriteLine("***** Fun with type conversions *****");

// Add two shorts and print result
short numb1 = 9, numb2 = 10;
Console.WriteLine("{0} + {1} = {2}", numb1, numb2, Add(numb1,  numb2));
Console.ReadLine();

// Compiler implicitly widens shorts to ints since no data is lost
static int Add(int x, int y)
{
   return x + y;
}

