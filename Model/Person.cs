using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour
{
    public class Person
    {
        static int idCounter = 0;
        public static int Counter { get { return idCounter; } }

        private readonly int id;
        private string firstName;
        private string lastName;

        public int Id { get { return id; } }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }
                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }
                lastName = value;
            }
        }
        public string FullName { get { return firstName + ' ' + lastName; } }

        public Person(string firstName, string lastName)
        {
            id = ++idCounter;
            FirstName = firstName;
            LastName = lastName;
        }

        public string Details()
        {
            return $"Name: {FullName} Your id: {id}";
        }

    }
}

