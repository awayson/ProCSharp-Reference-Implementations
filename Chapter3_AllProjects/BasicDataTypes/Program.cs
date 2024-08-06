using System.Numerics;

Console.WriteLine("*****Fun with Basic Data Types******");
LocalVarDeclarations();
DefaultDeclarations();
NewingDataTypes();
NewingDataTypesWith9();
ObjectFunctionality();
DataTypeFunctionality();
CharFunctionality();
ParseFromStrings();
ParseFromStringsWithTryParse();
UseDatesAndTimes();
UseDateOnlyAndTimeOnly();
DigitSeparators();
BinaryLiterals();

    static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    int myInt = 0;
    string myString = "This is my character data";
    Console.WriteLine();


    // Multiple variable declaration in one line
    bool b1 = true, b2 = false, b3 = b1;


    // Using full name to make declaration
    System.Boolean b4 = false;


    Console.WriteLine("Your data: {0}, {1}, {3}, {4}, {5}", myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();
}

static void DefaultDeclarations()
{
    Console.WriteLine("=> Default Declarations:");
    int myInt = default;
    Console.WriteLine(myInt);
}


// Intrinsic Data Types and the new Operator
// Intrinsic data types suppor the default constructor to create
//   variables using the new keyword and set the default value
static void NewingDataTypes()
{
    Console.WriteLine("=> Using new to create variables:");
    bool b = new bool();            //set to false
    int i = new int();              //set to 0
    double d = new double();        //set to 0
    DateTime dt = new DateTime();   //set to 1/1/0001 12:00:00 AM
    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

static void NewingDataTypesWith9()
{
    Console.WriteLine("=> Using new 'new();' to create variables:");
    bool b = new();        //set to false
    int i = new();         //set to 0
    double d = new();      //set to 0
    DateTime dt = new();   //set to 1/1/0001 12:00:00 AM

    Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
    Console.WriteLine();
}

// System.Int32 eventually derives from System.Object
static void ObjectFunctionality()
{
    Console.WriteLine("=> System.Object Functionality: ");
    // int is shorthand for System.Int32
    // inherits from System.Object
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}

static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data type functionality:");

    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);

    //Smallest representable 'double' which is greater than zero
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}", double.PositiveInfinity);
    Console.WriteLine("double.NegativeInifinity: {0}", double.NegativeInfinity);

    //Boolean functionality
    Console.WriteLine("System.Boolean supports TrueString/FalseString property: ");
    Console.WriteLine();
    Console.WriteLine("bool.FalseString: {0}", bool.FalseString);
    Console.WriteLine("bool.TrueString: {0}", bool.TrueString);

    Console.WriteLine();
}

static void CharFunctionality()
{
    Console.WriteLine("=> char type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine();
    Console.WriteLine("Specify index to check for whitespace in string:");
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}", char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}",
    char.IsPunctuation('?'));
    Console.WriteLine();
}

// Generate a variable of underlying type given a textual equivalent
static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
    }
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was assigned the default {1}", value, d);
    }
    Console.WriteLine();
}

static void UseDatesAndTimes()
{
    Console.WriteLine("=> Dates and Times:");

    // Takes in (year, month, day)
    DateTime dt = new DateTime(2015, 10, 17);

    // What day of the month is this?
    Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);

    // Move month forward
    dt = dt.AddMonths(2);
    Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());

    // Takes in (hours, minutes, seconds)
    TimeSpan ts = new TimeSpan(4, 30, 0);
    Console.WriteLine(ts);

    // Subtracting minutes from current TimeSpan
    Console.WriteLine(ts.Subtract(new TimeSpan(0, 15,0)));
}

// Represents half of the DateTime type, aligning with SQL Server Date type
static void UseDateOnlyAndTimeOnly()
{
    Console.WriteLine("=> Date and Times:");

    DateOnly d = new DateOnly(2021, 07, 21);
    Console.WriteLine(d);

    TimeOnly t = new TimeOnly(13,30,0,0);
    Console.WriteLine(t);
}


// Digit separators
// Improve readability
// Logical grouping
// No impact on value
static void DigitSeparators()
{
    Console.WriteLine("=> Use Digit Separators:");
    Console.Write("Integer:");
    Console.WriteLine(123_456);
    Console.Write("Long:");
    Console.WriteLine(123_456_789L);
    Console.Write("Float:");
    Console.WriteLine(123_456.1234F);
    Console.Write("Double:");
    Console.WriteLine(123_456.12);
    Console.Write("Decimal:");
    Console.WriteLine(123_456.12M);
    //Hex
    Console.Write("Hex:");
    Console.WriteLine(0x_00_00_FF);
}

// Digit separator with binary literals
static void BinaryLiterals()
{
    Console.WriteLine("=> Use Binary Literals:");
    Console.WriteLine("Sixteen: {0}", 0b_001_0000);
    Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);
    Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
}

