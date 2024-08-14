using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Classes
{
    class Car
    {
        // 'state'
        public string petName;
        public int currSpeed;

        public Car()
        {
            petName = "Chuck";
            currSpeed = 10;
        }

        public Car(string pn)
        {
            petName = pn;
        }

        public Car(string pn, int cs)
        {
            petName = pn;
            currSpeed = cs;
        }

        // Constructor with 'out' parameter C# 7.3
        public Car(string pn, int cs, out bool inDanger)
        {
            petName = pn;
            currSpeed = cs;
            if (cs > 100)
            {
                inDanger = true;
            }
            else
            {
                inDanger = false;
            }
        }

        // Functionality
        public void PrintState() => Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        public void speedUp(int deltal) => currSpeed += deltal; 
    }
}
