using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExamples
{
    class Car
    {
        private Radio myRadio = new Radio();

        public void TurnOnRadio(bool onOff)
        {
            myRadio.Power(onOff);
        }
    }
}
