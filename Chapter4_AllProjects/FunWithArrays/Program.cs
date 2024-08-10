using System.Text.Json.Serialization;

Console.WriteLine("**** Fun with Arrays ****");
SimpleArrays();
ArrayInitialization();
DeclareImplicitArrays();
RectMultidimensionalArray();
JaggedMultiDimensionalArray();

Console.ReadLine();

static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");

    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();


    string[] booksOnDotNet = new string[100];
    Console.WriteLine();
}

static void ArrayInitialization()
{
    Console.WriteLine("=> Array Initializtion.");

    // Using 'new'
    string[] stringArray = new string[] { "one", "two", "three" };
    Console.WriteLine("stringArray has {0} elements", stringArray.Length);

    // Not using 'new'
    bool[] boolArray = { false, false, true };
    Console.WriteLine("boolArray has {0} elements", boolArray.Length);

    //Using 'new' and size
    int[] intArray = new int[4] { 20, 22, 23, 0 };
    Console.WriteLine("intArray has {0} elements", intArray.Length);
    Console.WriteLine();
}

static void DeclareImplicitArrays()
{
    Console.WriteLine("=> Implicit Array Initialization.");

 
    // a i really int[]
    var a = new[] { 1, 10, 100, 1000 };
    Console.WriteLine("a is a: {0}", a.ToString());

    // b is really double[]
    var b = new[] { 1, 1.5, 2, 2.5 };
    Console.WriteLine("b is a: {0}", b.ToString());

    // c is really string[]
    var c = new[] { "hello", null, "world" };
    Console.WriteLine("c is a: {0}", c.ToString());
    

    Console.WriteLine();
}

static void ArrayOfObjects()
{
    Console.WriteLine("=> Array of Objects.");

    // An array of objects can be anything at all.
    object[] myObjects = new object[4];
    myObjects[0] = 10;
    myObjects[1] = false;
    myObjects[2] = new DateTime(1969, 3, 24);
    myObjects[3] = "Form & Void";
    foreach (object obj in myObjects)
    {
        Console.WriteLine("Type {0}, Value: {1}", obj.GetType(), obj);
    }
    Console.WriteLine();
}

static void RectMultidimensionalArray()
{
    Console.WriteLine("=> Rectangular multidimensional array.");

    // A rectangular MD array
    int[,] myMatrix;
    myMatrix = new int[3, 4];

    // Populate (3 * 4) array
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }

    // Print (3 * 4) array
    for(int i = 0; i < 3; i++)
    {
        for(int j = 0; j < 4; j++)
        {
            Console.Write(myMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void JaggedMultiDimensionalArray()
{
    Console.WriteLine("=> Jagged multidimensional array.");
    // A jagged MD array (i.e., an array of arrays)
    // An array of 5 different arrays
    int[][] myJagArray = new int[5][];

    // Create the jagged array
    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    // Print each row (remember, each element is defaulted to zero!)
    for (int i = 0; i < 5; i++)
    {
        for(int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// Examples of System.Array functionality
static void SystemArrayFunctionality()
{
    Console.WriteLine("=> Working with System.Array.");
    
    // Initialize items at startup.
    string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };
    
    // Print out names in declared order.
    Console.WriteLine("-> Here is the array:");
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name.
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");
    
    // Reverse them...
    Array.Reverse(gothicBands);
    Console.WriteLine("-> The reversed array");
    // ... and print them.
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name.
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine("\n");
    
    // Clear out all but the first member.
    Console.WriteLine("-> Cleared out all but one...");
    Array.Clear(gothicBands, 1, 2);
    for (int i = 0; i < gothicBands.Length; i++)
    {
        // Print a name.
        Console.Write(gothicBands[i] + ", ");
    }
    Console.WriteLine();
}
