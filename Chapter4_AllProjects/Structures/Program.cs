Console.WriteLine("**** A Look at Structures ****");

Point myPoint;
myPoint.X = 349;
myPoint.Y = 76;
myPoint.Display();

myPoint.Increment();
myPoint.Display();
myPoint.Decrement();

PointWithReadOnly p3 = new PointWithReadOnly(50, 60, "Point w/RO");
p3.Display();

struct Point
{
    // Fields of the structure.
    public int X;
    public int Y;

    public void Increment()
    {
        X++; Y++;
    }

    public void Decrement()
    {
        Y--; X--;
    }

    public void Display()
    {
        Console.WriteLine("X = {0}, Y = {1}", X, Y);
    }
}

readonly struct ReadOnlyPoint
{
    public int X { get; }
    public int Y { get; }

    public void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}");
    }

    public ReadOnlyPoint(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
}

struct PointWithReadOnly
{
    // Fields of structure
    public int X;
    public readonly int Y;
    public readonly string Name;

    public readonly void Display()
    {
        Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
    }

    public PointWithReadOnly(int xPos, int yPos, string name)
    {
        X = xPos;
        Y = yPos;
        Name = name;
    }
}