using System.Text;

// Default behavior for value types
static int Add(int x, int y)
{
    int ans = x + y;
    // Caller will not see these changes as you are modifying a copy of the original data
    x = 10000;
    y = 8888;
    return ans;
}

Console.WriteLine("**** Fun With Methods ****\n");

DisplayFancyMessage(message: "Wow! Very Fancy Indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);
DisplayFancyMessage(backgroundColor: ConsoleColor.Green, message: "Testing...", textColor: ConsoleColor.DarkBlue);








// Pass two variables by value
int x = 9, y = 10;
Console.WriteLine("Before call: X: {0}, Y: {1}", x, y);
Console.WriteLine("Answer is: {0}", Add(x, y));
Console.WriteLine("After call: X: {0}, Y: {1}", x, y);

Console.WriteLine("\n");

Console.WriteLine("Method with out modifer:");
AddWithOutModifier(90, 90, out int ans);
Console.WriteLine("90 + 90 = {0}", ans);

static void AddWithOutModifier(int x , int y, out int ans)
{
    ans = x + y;
}

// Returning multiple output parameters.
FillTheseValues(out int a, out string b, out bool c);
Console.WriteLine("Int is: {0}", a);
Console.WriteLine("String is {0}", b);
Console.WriteLine("Boolean is {0}", c);

static void FillTheseValues(out int a, out string b, out bool c)
{
    a = 9;
    b = "Enjoy your string.";
    c = true;
}


// Reference parameters
string str1 = "Flip";
string str2 = "Flop";
Console.WriteLine("Before: {0}, {1} ", str1, str2);
SwapStrings(ref str1, ref str2);
Console.WriteLine("After: {0}, {1}", str1, str2);

static void SwapStrings(ref string s1, ref string s2)
{
    string tempStr = s1;
    s1 = s2;
    s2 = tempStr;
}


// in Modifier
static int AddReadOnly(in int x, in int y)
{
    // Error CS8331 Cannot assign to variable 'in int' because it is a readonly variable
    // x = 10000;
    // y = 88888;
    int ans = x + y;
    return ans;
}


double average;
average = CalculateAverage(4.0, 3.2, 5.7, 64.22, 87.2);
Console.WriteLine("Average of data is: {0}", average);

double[] data = { 4.0, 3.2, 5.7 };
average = CalculateAverage(data);
Console.WriteLine("Average of data is: {0}", average);

Console.WriteLine("Average of data is: {0}", CalculateAverage());

// params Modifier
// Return average of "some number" of doubles.
static double CalculateAverage(params double[] values)
{
    Console.WriteLine("You sent me {0} doubles.", values.Length);

    double sum = 0;
    if (values.Length == 0)
    {
        return sum;
    }
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    return (sum / values.Length);
}

EnterLogData("Oh no! Grid can't find data");
EnterLogData("Oh no! I can't find the payroll data", "CFO");
//Optional Parameter
static void EnterLogData(string message, string owner = "Programmer")
{
    Console.WriteLine("Error: {0}", message);
    Console.WriteLine("Owner of Error: {0}", owner);
}


// Named Arguments
static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
{
    // Store old colors to restore after message is printed.
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldbackgroundColor = Console.BackgroundColor;
    // Set new colors and print message
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    // Restore previous colors
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldbackgroundColor;
}