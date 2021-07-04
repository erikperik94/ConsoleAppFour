using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppFour.Data;
using ConsoleAppFour.Model;

namespace ConsoleAppFour.Data
{
    public class People
    {
        private static Person[] personArray = new Person[0];
        //public string[] Person { get { return person; } }

        public int Size()
        {
            return personArray.Length;
        }

        public Person[] FindAll()
        {
            return personArray;
        }
        public Person FindById(int personId)
        {
            Person findPerson = Array.Find(personArray, id => id.PersonId == personId);
            return findPerson;
        }
        public Person AddPerson(string firstName, string lastName)
        {
            //Nya personen
            Person newPerson = new Person(firstName, lastName, PersonSequencer.NextPersonId());
            //Gör plats i Arrayen
            Array.Resize(ref personArray, Size() + 1);
            //Lägger personen längst bak på den nya platsen i Arrayen
            personArray[Size() - 1] = newPerson;

            return newPerson;
        }
        public void Clear()
        {
            Array.Resize(ref personArray, 0);
            PersonSequencer.ResetPerson();
        }
    }
}
