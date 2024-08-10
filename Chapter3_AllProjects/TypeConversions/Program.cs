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

// Compiler error will result below:
//short numb1 = 30000, numb2 = 30000;
//short answer = Add(numb1, numb2);

//Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);

Console.WriteLine("All narrowing conversions result in a compiler error, even when that conversion should succeed.");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("**** Explicit Casting ****");
short numb1 = 30000, numb2 = 30000;
// Explicitly cast the int into a short (and allow loss of data).
short answer = (short)Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}",
numb1, numb2, answer);
NarrowingAttempt();
Console.ReadLine();
static int Add(int x, int y)
{
    return x + y;
}
static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    // Explicitly cast the int into a byte (no loss of data).
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0}", myByte);
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("**** checked Keyword ****");
ProcessBytes();
static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;
    // This time, tell the compiler to add CIL code
    // to throw an exception if overflow/underflow
    // takes place.
    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}

