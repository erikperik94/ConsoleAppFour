using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppFour.Data;
using ConsoleAppFour.Model;

namespace ConsoleAppFour.Model
{
    public class Todo
    {


        private readonly int _todoId;
        private string description;
        private bool done;
        private Person assignee;

        public int TodoId { get { return _todoId; }  }

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
        public Todo(int todoId, string description)
        {
            this._todoId = todoId;
            Description = description;
        }
        
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        public Person Assignee
        {
            get { return assignee; }
            set
            { assignee = value; }
        }
    }
}
