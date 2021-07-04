using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour
{
    public class TodoSequencer
    {
        private static int _todoId = 0;
        public static int NextTodoId()
        {
            _todoId = ++_todoId;
            return _todoId;
        }
        public static void ResetTodo()
        {
            _todoId = 0;
        }
    }
}
