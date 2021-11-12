using System;

namespace abstracttask
{

    public abstract class Human
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return ($"{Name}, {Lastname}, {Age}");
        }


    }

    public abstract class Employ : Human
    {
        public string JobPositon { get; set; }
        public double Salary { get; set; }


        public abstract void Duties();
        public abstract void GetBonus();

        public override string ToString()
        {
            return ($"{Name}, {Lastname}, {Age}, {JobPositon}, {Salary}");
        }



    }




    public class Manager : Employ
    {
        public override void Duties()
        {
            Console.WriteLine($"agricxva, bonusebis gacema");
        }

        public override void GetBonus()
        {
            Console.WriteLine($"bonus{Salary * 0.5}\n");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Cashier : Employ
    {
        public override void Duties()
        {
            Console.WriteLine($"shemosavlis agricxva");
        }
        public override void GetBonus()
        {
            Console.WriteLine($"bonus{Salary * 0.8}\n");
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class StoreKeeper : Employ
    {
        public override void Duties()
        {
            Console.WriteLine($"store keeper");
        }
        public override void GetBonus()
        {
            Console.WriteLine($"bonus{Salary * 0.10}\n");
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager
            {
                Name = "ani",
                Lastname = "jbn",
                Age = 22,
                JobPositon = "manager",
                Salary = 1500
            };
            Console.WriteLine(m);
            m.Duties();
            m.GetBonus();



            Cashier c = new Cashier
            {
                Name = "john",
                Lastname = "dou",
                Age = 20,
                JobPositon = "cashier",
                Salary = 2000
            };
            Console.WriteLine(c);
            c.Duties();
            c.GetBonus();



            StoreKeeper st = new StoreKeeper
            {
                Name = "john",
                Lastname = "snow",
                Age = 26,
                JobPositon = "storekeeper",
                Salary = 3000
            };
            Console.WriteLine(st);
            st.Duties();
            st.GetBonus();
        }
    }
}