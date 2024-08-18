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
        private int _empAge;
        private int _empId;
        private float _currPay;
        private EmployeePayTypeEnum _payType;
        private DateTime _hireDate;

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
        public int Age
        {
            get => _empAge;
            set => _empAge = value;
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

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
        
        public DateTime HireDate
        {
            get => _hireDate;
            set => _hireDate = value;
        }

        public EmployeeWithProperties(string name, int age, int id, float pay, EmployeePayTypeEnum payType, DateTime hireDate)
        {
            _empName = name;
            _empAge = age;
            _empId = id;
            _currPay = pay;
            PayType = payType;
            HireDate = hireDate;
        }

        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                => Pay += amount,
                _ => Pay += 0
            };
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
        }

        // More than one property can be used in a pattern
        /*
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                {Age: >= 18, PayType: EmployeePayTypeEnum.Commission }
                    => Pay += .10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly }
                    => Pay += 40F * amount/2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried }
                    => Pay += amount,
                _ => Pay+=0
            };
        }
        */

        // Pattern matching can be nested
        /*
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                {Age: >= 18, PayType: EmployeePayTypeEnum.Commission , HireDate: { Year: > 2020 }}
                    => Pay += .10F * amount,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Hourly , HireDate: { Year: > 2020 } }
                    => Pay += 40F * amount/2080F,
                { Age: >= 18, PayType: EmployeePayTypeEnum.Salaried , HireDate: { Year: > 2020 } }
                    => Pay += amount,
                _ => Pay+=0
            };
        }
        */
        
        // C# 10 Extended Property Patterns
        /*
        public void GiveBonus(float amount)
        {
          Pay = this switch
          {
            {Age: >= 18, PayType: EmployeePayTypeEnum.Commision, HireDate.Year: > 2020 }
               => Pay += .10F * amount,
            {...}
               ...
          }
        }
        */
    }
}
