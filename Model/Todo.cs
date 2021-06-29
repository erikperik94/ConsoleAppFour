using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFour
{
    public class Todo
    {


        private readonly int todoId;
        private string description;
        private bool done;
        private Person assigne;

        public int TodoId { get { return todoId; }  }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Empty or only whitespace is not allowed.");
                }
                description = value;
            }
        }
        public Todo(int number, string description)
        {
            todoId = number;
            Description = description;
        }

        public string Details()
        {
            return $"TodoId: {todoId} Description: {Description}";
        }


    }
}
