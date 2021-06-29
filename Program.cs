using System;

namespace ConsoleAppFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Erik","Aggfelt");
            Console.WriteLine(person.Details());
        }
    }
}
