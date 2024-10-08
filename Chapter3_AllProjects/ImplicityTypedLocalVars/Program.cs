﻿using System.Globalization;

Console.WriteLine("***** Fun with Implicit Typing *****");

DeclareImplicitVars();
DeclareImplicitNumerics();
LinqQueryOverInts();


    static void DeclareImplicitVars()
{
    // Implicitly typed local variables
    // are declared as follows:
    // var variableName = initialValue;
    var myInt = 0;
    var myBool = true;
    var myString = "Time, marches on...";

    // reflection:
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
    Console.WriteLine("myString is a: {0}", myString.GetType().Name);
}

Console.WriteLine();


static void DeclareImplicitNumerics()
{
    Console.WriteLine("=> Implicit Numerics");

    var myUInt = 0u;
    var myInt = 0;
    var myLong = 0L;
    var myDouble = 0.5;
    var myFloat = 0.5F;
    var myDecimal = 0.5M;

    Console.WriteLine("myUInt is a: {0}", myUInt.GetType().Name);
    Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
    Console.WriteLine("myLong is a: {0}", myLong.GetType().Name);
    Console.WriteLine("myDouble is a: {0}", myDouble.GetType().Name);
    Console.WriteLine("myFloat is a: {0}", myFloat.GetType().Name);
    Console.WriteLine("myDecimal is a: {0}", myDecimal.GetType().Name);
}

static void LinqQueryOverInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };

    //LINQ query
    var subset = from i in numbers where i < 10 select i;

    Console.WriteLine("Values in subset: ");
    foreach (var i in subset)
    {
        Console.WriteLine("{0}, ", i);
    }
    Console.WriteLine();

    // What is type of subset?
    Console.WriteLine("subset is a: {0}", subset.GetType().Name);
    Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
}