using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour
{
    public class PersonSequencer
    {
        static int idCounter = 0;
        public int IdCounter { get { return idCounter; } }

        private static int personId;
        public int PersonId { get { return personId; } }
        static int nextPersonId()
        {
            personId = ++idCounter;
            return personId;
        }
        static int reset()
        {
            idCounter = 0;

            return idCounter;
        }
        public int Reset()
        {
            return reset();
        }
        public int NextPersonId()
        {
            return nextPersonId();
        }
        public PersonSequencer()
        {

        }
        public string Details()
        {
            return $"{personId}";
        }
    }
}
