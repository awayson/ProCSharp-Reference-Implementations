using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Motorcycle
    {
        public int driverIntensity;
        public string name;
        
        public void SetDriverName(string name) { this.name = name; }

        //public void SetDriverName(string name) => name = name;

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeee Haaaaaaaeewww!");
        }
        public Motorcycle() { }

        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
    }

    // Observing Constructor Flow
    class MotorcycleChaining
    {
        public int driverIntensity;
        public string name;

        public void SetDriverName(string name) { this.name = name; }

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeee Haaaaaaaeewww!");
        }

        public MotorcycleChaining() 
        {
            Console.WriteLine("In default constructor");
        }

        public MotorcycleChaining(int intensity)
            : this(intensity, "")
        {
            Console.WriteLine("In constructor taking an int"); //After chaining to master, flow returns here
        }

        public MotorcycleChaining(string name)
            : this(0, name) 
        {
            Console.WriteLine("In constructor taking a string");
        }

        // 'Master' constructor
        public MotorcycleChaining(int intensity, string name)
        {
            Console.WriteLine("In main constructor");
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            this.name = name;
        }
    }


    class MotorcycleOptionalArgs
    {
        public int driverIntensity;
        public string name;

        public void SetDriverName(string name) { this.name = name; }

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeee Haaaaaaaeeew!");
        }

        // Single constructor using optional args
        public MotorcycleOptionalArgs(int intensity = 0, string name = "")
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            driverIntensity = intensity;
            this.name = name;
        }
    }
}
