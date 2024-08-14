using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    static class TimeUtilClass
    {
        public static void PrintTime() => Console.WriteLine(DateTime.Now.ToShortTimeString());

        public static void PrintDate() => Console.WriteLine(DateTime.Today.ToShortTimeString());
    }
}

// using static System.Console;
// using static System.DateTime;

/*
static class TimeUtilClass
{
    public static void PrintTime()
        => WriteLine(Now.ToShortTimeString());
    public static void PrintDate()
        => WriteLine(Today.ToShortDateString());
}
*/ 
