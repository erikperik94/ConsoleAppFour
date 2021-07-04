using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppFour.Data;
using ConsoleAppFour.Model;

namespace ConsoleAppFour.Data
{
    public class TodoItems
    {
        private static Todo[] itemsArray = new Todo[0];

        public int Size()
        {
            return itemsArray.Length;
        }

        public Todo[] FindAll()
        {
            return itemsArray;
        }
        public Todo FindById(int todoId)
        {
            Todo findTodo = Array.Find(itemsArray, id => id.TodoId == todoId);
            return findTodo;
        }
        public Todo AddTodo(string description)
        {
            Todo newTodo = new Todo(TodoSequencer.NextTodoId(), description);
            Array.Resize(ref itemsArray, Size() + 1);
            itemsArray[Size() - 1] = newTodo;
            return newTodo;
        }
        public void Clear()
        {
            Array.Resize(ref itemsArray, 0);
            TodoSequencer.ResetTodo();
        }
    }
}
