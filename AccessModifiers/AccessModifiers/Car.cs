using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Car : Transport
    {
        public int WheelCount;

        private string Color;

        public Car(int year, int weight, int maxSpeed, int wheelCount) : base(year, weight, maxSpeed)
        {
            WheelCount = wheelCount;
            Color = "Blue";
        }

        public override string GetFullInfo()
        {
            Year = 10;
            Color = "Test";
            Test t1 = new Test();
            Print();
            return base.GetFullInfo() + " " + WheelCount;
        }

        private void Print()
        {
            Type = "Afsgasgasg";
            Console.WriteLine(Type);
        }

        private class Test
        {

        }
    }
}
