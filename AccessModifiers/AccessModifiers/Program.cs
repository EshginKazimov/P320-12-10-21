using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car(2010, 3, 260, 4);
            Ship s1 = new Ship(2000, 150, 30, 3);

            //Transport[] transports = { c1, s1 };
            //foreach (var item in transports)
            //{
            //    Console.WriteLine(item.GetFullInfo());
            //}

            #region Public - all members (fields, class, properties, methods)

            c1.Year = 10;
            c1.Weight = 5;

            #endregion

            #region Private - all members (fields, class, properties, methods)

            //c1.Color = "Red";
            //Test 
            //c1.Print();

            #endregion

            #region Protected - (fields, properties, methods)

            //Instance alanda gorunmur
            //Yalniz inheritance zamani gorunur

            //c1.Type = "";
            //Console.WriteLine(c1.Type);

            #endregion

            #region Encapsulate, Property

            //Teacher t1 = new Teacher("");
            //t1.Age = 20;
            //if (t1.Age <= 20)
            //{
            //    Console.WriteLine("Bu yashda mellim ola bilmez");
            //}
            //else
            //{
            //    Console.WriteLine(t1.Age);
            //}
            //t1.SetAge(20);
            //t1.Age = 20;
            //t1.Age = 15;
            //Console.WriteLine(t1.Age);

            //t1.Name = "";
            //Console.WriteLine(t1.Name);
            //t1.Department

            //t1.Surname = "";
            //t1._test = "";
            //t1._demo = "";
            //Console.WriteLine(t1._demo);
            //Console.WriteLine(t1.Surname);

            #endregion

            //Student class-i yaradin. Name,Surname,Age,Mark property-leri olsun.
            //Mark 0-100 arasi deyerler ala bilsin, eks halda xeberdarliq chixsin.
        }
    }
}
