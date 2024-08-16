using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class EmployeeWithProperties
    {
        private string _empName;
        private int _empId;
        private float _currPay;

        // Properies
        public string Name
        {
            get { return _empName; }
            set
            {
                // Value is a contextual keyword, here it is a string
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name length exceeds 15 characters!");
                }
                else
                {
                    _empName = value;
                }
            }
        }
        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public EmployeeWithProperties(string name, int id, float pay)
        {
            _empName = name;
            _empId = id;
            _currPay = pay;
        }

        public void GiveBonus(float amount) => _currPay += amount;
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }
    }
}
