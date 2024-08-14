var values = ("a", 5, "c");

Console.WriteLine($"First item: {values.Item1}");
Console.WriteLine($"Second item: {values.Item2}");
Console.WriteLine($"Third item: {values.Item3}");

var valuesWithNames = (FirstLetter: "a", TheNumber: 5, SecondLetter: "c");

Console.WriteLine($"First item: {valuesWithNames.FirstLetter}");
Console.WriteLine($"Second item: {valuesWithNames.TheNumber}");
Console.WriteLine($"Third item: {valuesWithNames.SecondLetter}");


Console.WriteLine("=> Nested Tuples");
var nt = (5, 4, ("a", "b"));


Console.WriteLine("=> Inferred Tuple Names");

// Creates anonymous object with two properties
var foo = new { Prop1 = "first", Prop2 = "second" };

// Creates tuple, C# automatically names the elements, matching property names from foo
var bar = (foo.Prop1, foo.Prop2);

// Prints first/second
Console.WriteLine($"{bar.Prop1};{bar.Prop2}");



Console.WriteLine("=> Tuples Equality/Inequality");
// Lifted conversions
var left = (a: 5, b: 10);
(int? a, int? b) nullableMembers = (5, 10);
Console.WriteLine(left == nullableMembers); //True

// Converted type of left is (long, long)
(long a, long b) longTuple = (5, 10);
Console.WriteLine(left == longTuple); //True

// Comparisons performed on (long, long) tuples
(long a, int b) longFirst = (5, 10);
(int a, long b) longSecond = (5, 10);
Console.WriteLine(left == longSecond); //True


// Tuples as Method Return Values
var samples = FillTheseValues();
Console.WriteLine($"Int is: {samples.a}");
Console.WriteLine($"String is: {samples.b}");
Console.WriteLine($"Boolean is: {samples.c}");
static (int a, string b, bool c) FillTheseValues()
{
    return (9, "Enjoy your string.", true);
}

// Tuple Discards
var (first, _, last) = SplitNames("Philip F Japikse");
Console.WriteLine($"{first}:{last}");

static (string first, string middle, string last) SplitNames(string fullName)
{
    //do what is needed to split the name apart
    return ("Philip", "F", "Japikse");
}


// Deconstructing a tuple
(int X, int Y) myTuple = (4, 5);
int x = 0;
int y = 0;
(x, y) = myTuple;
Console.WriteLine($"X is: {x}"); //4
Console.WriteLine($"Y is: {y}"); //5

// Deconstructing with inline initialization
(int x1, int y1) = myTuple;
Console.WriteLine($"x1 is: {x1}");
Console.WriteLine($"y1 is: {y1}");

// Deconstructing with mixed assignment and declaration
int x2 = 0;
(x2, int y2) = myTuple;
Console.WriteLine($"x2 is: {x2}");
Console.WriteLine($"y2 is: {y2}");


