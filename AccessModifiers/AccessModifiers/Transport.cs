using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Transport
    {
        public int Year;
        public int Weight;
        public int MaxSpeed;

        protected string Type;

        public Transport(int year, int weight, int maxSpeed)
        {
            Year = year;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Type = "fasfasfasg";
        }

        public virtual string GetFullInfo()
        {
            return $"{Year} {Weight} {MaxSpeed}KmH";
        }
    }
}
