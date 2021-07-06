using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppFour.Data;
using ConsoleAppFour.Model;

namespace ConsoleAppFour.Data
{
    public class PersonSequencer
    {
        private static int _personId;
        public static int NextPersonId()
        {
            _personId = ++_personId;
            return _personId;
        }
        public static void ResetPerson()
        {
            _personId = 0;
        }
    }
}
