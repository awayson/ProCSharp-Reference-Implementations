using System;

namespace FunWithEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Enums ****\n");
            EmpTypeEnum emp = EmpTypeEnum.Contractor;
            AskForBonus(emp);
            // Get type using a variable of the entity
            Console.WriteLine("EmpTypeEnum uses {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            // Get type without using a variable of the entity
            Console.WriteLine("EmpTypeEnum uses {0} for storage", Enum.GetUnderlyingType(typeof(EmpTypeEnum)));
            // Print string name of an enum's value
            Console.WriteLine("emp is a {0}.", emp.ToString());
            // Get the value of a particular enum (via casting)
            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);
            EmpTypeEnum e2 = EmpTypeEnum.Contractor;
            // These types are enums in the System namespace.
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;
            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);
            Console.ReadLine();
        }

        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }

        // This method will print out the details of any enum.
        static void EvaluateEnum(Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);
            Console.WriteLine("Underlying storage type: {0}",
            Enum.GetUnderlyingType(e.GetType()));
            // Get all name-value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);
            // Now show the string name and associated value, using the D format
            // flag (see Chapter 3).
            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}",
                enumData.GetValue(i));
            }
        }
    }

    // A custom enumeration.
    enum EmpTypeEnum
    {
        Manager,          // = 0
        Grunt,            // = 1
        Contractor,       // = 2
        VicePresident     // = 3
    }

    /* Set custom values
    enum EmpTypeEnum
    {
        Manager = 102,    // = 102
        Grunt,            // = 103
        Contractor,       // = 104
        VicePresident     // = 105
    }
    */

    /*
    // This time, EmpTypeEnum maps to an underlying byte.
    enum EmpTypeEnum : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }
    */
}

