using System;

namespace ConsoleAppFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Erik","Aggfelt");
            Person person1 = new Person("Göran","Persson");
            Todo work = new Todo(4,"clean up");
            Todo work1 = new Todo(5,"do the dishes");

            Console.WriteLine(person.Details());
            Console.WriteLine(work.Details());
            Console.WriteLine(work1.Details());
        }
    }
}
