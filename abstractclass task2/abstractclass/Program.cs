using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11SM011
{
    public abstract class Human
    {
        string _fname;
        string _lname;
        DateTime _bd;

        public Human(string _fname, string _lname, DateTime _bd)
        {
            this._fname = _fname;
            this._lname = _lname;
            this._bd = _bd;
        }
        public abstract void Think();
        public override string ToString()
        {
            return $"{_fname}, {_lname}, {_bd.ToShortDateString()}";
        }

    }
    public abstract class Learner : Human
    {
        string _saswavlebeli;
        public Learner(string saxeli, string gvari, DateTime dt, string saswavlebeli) :
            base(saxeli, gvari, dt)
        {
            _saswavlebeli = saswavlebeli;
        }
        public abstract void Study();
        public override string ToString()
        {
            return base.ToString() + $" {_saswavlebeli}";
        }
    }
    public class Student : Learner
    {
        string _groupNumber;
        public Student(string saxeli, string gvari, DateTime dt, string saswavlebeli, string group) :
            base(saxeli, gvari, dt, saswavlebeli)
        {
            _groupNumber = group;
        }
        public override void Study()
        {
            Console.WriteLine("me vswavlob c#-s saswavlebelshi");
        }

        public override void Think()
        {
            Console.WriteLine("me vfiqrob rogorc studenti");
        }
        public override string ToString()
        {
            return base.ToString() + $" {_groupNumber}";
        }
    }
    public class SchoolChild : Learner
    {
        string _className;
        public SchoolChild(string saxeli, string gvari, DateTime dt, string saswavlebeli, string _className) :
            base(saxeli, gvari, dt, saswavlebeli)
        {
            this._className = _className;
        }
        public override void Study()
        {
            Console.WriteLine("me vswavlob skolashi qartuls, matematikas da assh...");
        }

        public override void Think()
        {
            Console.WriteLine("me vfiqrob rogorc skolis moswavle");
        }
        public override string ToString()
        {
            return base.ToString() + $" {_className}";
        }
    }


    public abstract class Adamiani
    {
        public string Saxeli { get; set; }
        public string Gvari { get; set; }
        public int Asaki { get; set; }

        public override string ToString()
        {
            return $"{Saxeli}, {Gvari}, {Asaki}";
        }
    }

    public abstract class Samsaxuri : Adamiani
    {
        public string Pozicia { get; set; }
        public int Xelfasi { get; set; }

        public abstract void SamushaosAghwera();
        public abstract void Bonusi();
        public override string ToString()
        {
            return base.ToString() + $", {Pozicia}, {Xelfasi}";
        }
    }
    public class Manager : Samsaxuri
    {
        public override void Bonusi()
        {
            Console.WriteLine($"{Xelfasi * 0.05}");
        }

        public override void SamushaosAghwera()
        {
            Console.WriteLine("9dan 6 saatamde samsaxurshi yofna!");
        }
    }
    public class Molare : Samsaxuri
    {
        public override void Bonusi()
        {
            Console.WriteLine($"{Xelfasi * 0.05}");
        }

        public override void SamushaosAghwera()
        {
            Console.WriteLine("fulis datvla da gacema");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Learner[] learners =
            //{
            //    new Student("John","Doe",DateTime.Now,"Harvard university","SM011"),
            //    new SchoolChild("Jane","Doe",new DateTime(2007,05,12),"31 sajaro skola","A")
            //};
            //foreach (var item in learners)
            //{
            //    Console.WriteLine(item);
            //    item.Study();
            //    item.Think();
            //}

            Samsaxuri[] tanamshromlebi =
            {
                new Manager{Saxeli="ani",Gvari = "jabannishvili",Asaki=25,Pozicia="IT Manager",Xelfasi =1200},
                new Manager{Saxeli="Giorgi",Gvari = "Giorgadze",Asaki=21,Pozicia="Sales Manager",Xelfasi =1200},
                new Molare{Saxeli="Parmen",Gvari = "Jokovic",Asaki=21,Pozicia="Molare operatori",Xelfasi =1200}
            };
            foreach (var item in tanamshromlebi)
            {
                Console.WriteLine(item);
                item.SamushaosAghwera();
                item.Bonusi();
            }

            Console.Read();
        }
    }
}