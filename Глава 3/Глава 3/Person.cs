using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Глава_3
{
    public class Person
    {

        public string name = "Dima";
        public int age = 30;
        public string email = "leonidi4@list.ru";

       // public Person() { name = "Udefault"; age = 18; }
       // public Person(string temp="___") { name = temp ; age = 18; }
        public Person(string temp="Noname", int temp1=0) { name = temp; age = temp1; }

        public void Print()
        {
            Console.WriteLine($"Имя {name} Возраст {age} Мыло {email}");
        }

        public void Deconstryctor(out string dname, out int dage)
        {
            dname = name;
            dage = age;
        }
    }
}
