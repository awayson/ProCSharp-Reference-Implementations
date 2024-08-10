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