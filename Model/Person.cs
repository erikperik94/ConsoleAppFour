using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppFour;

namespace ConsoleAppFour
{
    public class Person
    {

        private readonly int id;
        private string firstName;
        private string lastName;

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
            
            FirstName = firstName;
            LastName = lastName;
        }

        public string Details()
        {
            return $"{FullName}";
        }

    }
}

