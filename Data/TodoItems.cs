using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour.Data
{
    class TodoItems
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
        public Todo AddPerson(string description)
        {
            Todo newTodo = new Todo(TodoSequencer.NextTodoId(), description);
            Array.Resize(ref itemsArray, Size() + 1);
            itemsArray[Size() - 1] = newTodo;
            return newTodo;
        }
        public void Clear()
        {
            Array.Resize(ref itemsArray, 0);
            PersonSequencer.ResetPerson();
        }
    }
}
