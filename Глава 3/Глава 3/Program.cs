using Глава_3;

Person newuser = new Person("Tom");   //("Vasia", 35, "nekto@mail.ru");
//newuser.name = "Анжелика";
//(string name, int age) = newuser;
newuser.Deconstryctor(out string dname, out int age);

newuser.Print();
Console.WriteLine($"{dname}");

/*string name = Misha.name;
int age = Misha.age;

Console.WriteLine($"Взялиданные из класса и получили \n Имя {name} Возраст {age}");


Console.WriteLine();

Misha.name = "Eduard";
Misha.age = 20;

Misha.Print();

Console.WriteLine($"Вывод константы {Person.type}");
Person.type = "Vasia";
class Person
{
    public const string type = "Person";
    public string name =  "Undefined" ;
    public int age;

    public void Print() 
    {
        Console.WriteLine($"Имя {name}  Возраст {age}");
    }
}*/