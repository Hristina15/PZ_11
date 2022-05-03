using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_11
{
    class Program
    {   // 2 вариант Минеева Христина
        struct Person
        {
            // структура с численными полями и метод, который отображает значения полей, с символьными методами не получилось
            // так как невозможно создать с символьными значениями  
            public int age;

            public void Print()
            {
                Console.WriteLine($"Возраст: {age}"); 
            }
        }
        static void Main(string[] args)
        {
            // создали указатель на экземпляр, присовили значения и вызвали метод из экземпляра
            unsafe // в этом методе можно использовать указатели, бращаться к методам с помощью указателей
            {
                Person person = new Person();
                Person* ps1 = &person;
                ps1->age = 18;
                ps1->Print();
                Console.ReadLine();
            }
        }
    }
}
