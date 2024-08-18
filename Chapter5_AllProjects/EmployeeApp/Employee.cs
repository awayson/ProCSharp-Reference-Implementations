using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        // Fields
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private EmployeePayTypeEnum _payType;

        // Accessor (get method)
        public string GetName() => _empName;
        
        // Mutator (set method)
        public void SetName(string name)
        {
            if(name.Length > 15)
            {
                Console.WriteLine("Error! Name length exceeds 15 characters!");
            }
            else
            {
                _empName = name;
            }
        }

        // Property that can respond to intrinsic operators in C#
        public int Age
        {
            get { return _empAge; }
            set { _empAge = value; } //Note contextual keyword here is acting as an int
        }

        // Constructors
        public Employee() { }
        // Constructor chaining
        public Employee(string name, int id, float pay)
            :this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _empAge = age;
            _currPay = pay;
        }

        // Methods
        public void GiveBonus(float amount) => _currPay += amount;

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }
}

