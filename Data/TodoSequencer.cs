using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour
{
    public class TodoSequencer
    {
        static int idCounter = 0;
        public int IdCounter { get { return idCounter; } }

        private static int personId;
        public int PersonId { get { return personId; } }
        static int nextTodoId()
        {
            personId = ++idCounter;
            return personId;
        }
        static int resetTodo()
        {
            idCounter = 0;
            return idCounter;
        }
        public int ResetTodo()
        {
            return resetTodo();
        }
        public int NextTodoId()
        {
            return nextTodoId();
        }
        public TodoSequencer()
        {

        }
        public string Details()
        {
            return $"{personId}";
        }
    }
}
