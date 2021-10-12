using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Teacher
    {
        //Property
        public string Name { get; private set; }
        public string Surname { get; }
        private string Department { get; set; }

        private int _age;
        public int Age
        {
            get
            {
                if (_age > 20)
                    return _age;

                return -1;
            }
            set
            {
                if (value > 20)
                {
                    _age = value;
                    return;
                }

                Console.WriteLine("Bu yashda mellim ola bilmez!");
            }
        }

        private readonly string _test;
        public readonly int _demo;

        public Teacher(string surname)
        {
            Surname = surname;
            _test = "";
            _demo = 0;
        }

        public void Test()
        {
            Name = "";
            Console.WriteLine(Name);
            //_test = "";
            //Surname = "Test";
            //_demo = 0;
        }

        //public int GetAge()
        //{
        //    if (Age > 20)
        //        return Age;

        //    return -1;
        //}

        //public void SetAge(int age)
        //{
        //    if (age > 20)
        //    {
        //        Age = age;
        //        return;
        //    }

        //    Console.WriteLine("Bu yashda mellim ola bilmez!");
        //}
    }
}
