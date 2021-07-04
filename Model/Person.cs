using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour
{
    public class Person
    {

        private readonly int _personId;
        private string firstName;
        private string lastName;

        public int PersonId { get { return _personId; } }

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


        public Person(string firstName, string lastName, int personId)
        {
            this._personId = personId;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

