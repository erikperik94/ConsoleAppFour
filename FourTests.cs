using System;
using Xunit;
using ConsoleAppFour.Data;
using ConsoleAppFour.Model;

namespace ConsoleAppFour.Test
{
    public class FourTests
    {
        [Fact]
        public void PersonTestNameHoping()
        {
            //Arrange
            string firstName = "Erik";
            string lastName = "Aggfelt";
            string firstName2 = "Göran";
            string lastName2 = "Persson";

            //Act
            Person person1 = new Person(firstName, lastName, 1);
            Person person2 = new Person(firstName2, lastName2, 2);

            //Assert
            Assert.NotEqual(firstName, person2.FirstName);
            Assert.NotEqual(lastName, person2.LastName);
            Assert.NotEqual(firstName2, person1.FirstName);
            Assert.NotEqual(lastName2, person1.LastName);

        }

        [Fact]
        public void PersonTestId()
        {
            //Arrange
            string firstName = "Erik";
            string lastName = "Aggfelt";
            string firstName2 = "Göran";
            string lastName2 = "Persson";
            //Act
            Person person1 = new Person(firstName, lastName, 1);
            Person person2 = new Person(firstName2, lastName2, 2);
            //Assert
            Assert.NotEqual(person1.PersonId, person2.PersonId);
        }

        [Fact]
        public void PersonTestNames()
        {
            //Arrange
            string firstName = "Erik";
            string lastName = "Aggfelt";
            string firstName2 = "Göran";
            string lastName2 = "Persson";
            //Act
            Person person1 = new Person(firstName, lastName, 1);
            Person person2 = new Person(firstName2, lastName2, 2);
            //Assert
            Assert.Equal(firstName, person1.FirstName);
            Assert.Equal(lastName, person1.LastName);
            Assert.Equal(firstName2, person2.FirstName);
            Assert.Equal(lastName2, person2.LastName);

        }
        [Fact]
        public void TodoTestNameHoping()
        {
            //Arrange
            string Todo1 = "clean up";
            string Todo2 = "do the dishes";
            //Act
            Todo work1 = new Todo(4, Todo1);
            Todo work2 = new Todo(5, Todo2);

            //Assert
            Assert.NotEqual(Todo1, work2.Description);
            Assert.NotEqual(Todo2, work1.Description);

        }

        [Fact]
        public void TodoTestId()
        {
            //Arrange
            string Todo1 = "clean up";
            string Todo2 = "do the dishes";
            //Act
            Todo work1 = new Todo(4, Todo1);
            Todo work2 = new Todo(5, Todo2);
            //Assert
            Assert.NotEqual(work1.TodoId, work2.TodoId);
        }
        [Fact]
        public void TodoTestNames()
        {
            //Arrange
            string Todo1 = "clean up";
            string Todo2 = "do the dishes";
            //Act
            Todo work1 = new Todo(4, Todo1);
            Todo work2 = new Todo(5, Todo2);
            //Assert
            Assert.Equal(Todo1, work1.Description);
            Assert.Equal(Todo2, work2.Description);
        }
        [Fact]
        public void PersonSequencerTestCount()
        {
            //Arrange
            int firstcount = 1;
            //Act
            //PersonSequencer count1 = new PersonSequencer();
            //Assert
            Assert.Equal(firstcount, PersonSequencer.NextPersonId());
        }
        [Fact]
        public void PersonSequencerTestMoreCount()
        {
            //Arrange
            int firstcount = 4;
            //Act
            //PersonSequencer count1 = new PersonSequencer();
            PersonSequencer.ResetPerson();
            PersonSequencer.NextPersonId(); //1
            PersonSequencer.NextPersonId(); //2
            PersonSequencer.NextPersonId(); //3
            //Assert
            Assert.Equal(firstcount, PersonSequencer.NextPersonId()/* //4 */);

        }
        [Fact]
        public void PersonSequencerTestReset()
        {
            //Arrange
            int resetcount = 1;
            //Act
            PersonSequencer.ResetPerson();
            //PersonSequencer count1 = new PersonSequencer();
            //Assert
            Assert.Equal(resetcount, PersonSequencer.NextPersonId());

        }
        [Fact]
        public void TodoSequencerTestCount()
        {
            //Arrange
            int firstcount = 1;
            //Act
            //TodoSequencer count1 = new TodoSequencer();
            TodoSequencer.ResetTodo();
            //Assert
            Assert.Equal(firstcount, TodoSequencer.NextTodoId());
        }
        [Fact]
        public void TodoSequencerTestMoreCount()
        {
            //Arrange
            int firstcount = 4;
            //Act
            //TodoSequencer count1 = new TodoSequencer();
            TodoSequencer.ResetTodo();
            TodoSequencer.NextTodoId(); //1
            TodoSequencer.NextTodoId(); //2
            TodoSequencer.NextTodoId(); //3
            //Assert
            Assert.Equal(firstcount, TodoSequencer.NextTodoId()/* //4 */);
        }
        [Fact]
        public void TodoSequencerTestReset()
        {
            //Arrange
            int resetcount = 1;
            //Act
            TodoSequencer count1 = new TodoSequencer();
            TodoSequencer.ResetTodo();
            //Assert
            Assert.Equal(resetcount, TodoSequencer.NextTodoId());
        }
        [Fact]
        public void PeopleTest()
        {
            //Arrange
            People testPeople = new People();
            string firstName1 = "Erik";
            string lastName1 = "Aggfelt";
            string firstName2 = "Jonas";
            string lastName2 = "Östensson";
            string firstName3 = "James";
            string lastName3 = "Winkler";
            //Act
            testPeople.Clear();
            Person Person1 = testPeople.AddPerson(firstName1, lastName1);
            Person Person2 = testPeople.AddPerson(firstName2, lastName2);
            Person Person3 = testPeople.AddPerson(firstName3, lastName3);
            Person foundById = testPeople.FindById(1);
            Person[] All1 = testPeople.FindAll();
            Person[] All2 = testPeople.FindAll();
            //Assert
            Assert.Equal(firstName1, Person1.FirstName);
            Assert.Equal(firstName2, Person2.FirstName);
            Assert.Equal(lastName3, Person3.LastName);
            Assert.Equal(1, Person1.PersonId);
            Assert.Equal(2, Person2.PersonId);
            Assert.NotEqual(lastName1, Person2.LastName);
            Assert.NotEqual(Person1.PersonId, Person3.PersonId);
            Assert.Equal(Person1, foundById);
            Assert.NotEqual(Person2, foundById);
            Assert.Equal(All1, All2);
        }
        [Fact]
        public void TodoItemsTest()
        {
            //Arrange
            TodoItems testTodoItem = new TodoItems();
            string description1 = "Diska";
            string description2 = "Städa";
            string description3 = "Tvätta";
            //Act
            testTodoItem.Clear();
            Todo TodoItem1 = testTodoItem.AddTodo(description1);
            Todo TodoItem2 = testTodoItem.AddTodo(description2);
            Todo TodoItem3 = testTodoItem.AddTodo(description3);
            Todo foundById = testTodoItem.FindById(1);
            Todo[] All1 = testTodoItem.FindAll();
            Todo[] All2 = testTodoItem.FindAll();
            //Assert
            Assert.Equal(description1, TodoItem1.Description);
            Assert.Equal(description2, TodoItem2.Description);
            Assert.Equal(description3, TodoItem3.Description);
            Assert.Equal(1, TodoItem1.TodoId);
            Assert.Equal(3, TodoItem3.TodoId);
            Assert.NotEqual(1, TodoItem3.TodoId);
            Assert.NotEqual(3, TodoItem1.TodoId);
            Assert.Equal(TodoItem1, foundById);
            Assert.NotEqual(TodoItem3, foundById);
            Assert.Equal(All1, All2);


        }
        [Fact]
        public void TodoItemsTestAssignment10()
        {
            //Arrange
            TodoItems testTodoItem = new TodoItems();
            string description1 = "Diska";
            string description2 = "Städa";
            string description3 = "Tvätta";

            People testPeople = new People();
            string firstName1 = "Erik";
            string lastName1 = "Aggfelt";
            string firstName2 = "Jonas";
            string lastName2 = "Östensson";
            string firstName3 = "James";
            string lastName3 = "Winkler";
            //Act
            testTodoItem.Clear();
            Todo TodoItem1 = testTodoItem.AddTodo(description1);
            Todo TodoItem2 = testTodoItem.AddTodo(description2);
            Todo TodoItem3 = testTodoItem.AddTodo(description3);

            testPeople.Clear();
            Person Person1 = testPeople.AddPerson(firstName1, lastName1);
            Person Person2 = testPeople.AddPerson(firstName2, lastName2);
            Person Person3 = testPeople.AddPerson(firstName3, lastName3);

            TodoItem1.Assignee = Person1;
            TodoItem2.Assignee = Person2;

            TodoItem1.Done = true;
            TodoItem2.Done = false;
            TodoItem3.Done = true;

            Todo[] allTrue = testTodoItem.FindByDoneStatus(true);
            Todo[] allFalse = testTodoItem.FindByDoneStatus(false);
            Todo[] AssigneeID1 = testTodoItem.FindByAssignee(Person1.PersonId);
            Todo[] AssigneeID2 = testTodoItem.FindByAssignee(Person3.PersonId);
            Todo[] Assignee1 = testTodoItem.FindByAssignee(Person1);
            Todo[] Assignee2 = testTodoItem.FindByAssignee(Person2);

            Todo[] UnassigneeItems = testTodoItem.FindUnassignedTodoItems();
            //Assert
            Assert.Contains(TodoItem1, allTrue);
            Assert.Contains(TodoItem2, allFalse);
            Assert.NotEqual(Assignee2, Assignee1);
            Assert.NotNull(UnassigneeItems);
            Assert.NotEqual(AssigneeID1, AssigneeID2);
        }
        [Fact]
        public void RemoveTest()
        {
            //Arrange
            TodoItems testTodoItem = new TodoItems();
            string description1 = "Diska";
            string description2 = "Städa";
            string description3 = "Tvätta";
            //Act
            TodoSequencer.ResetTodo();
            Todo TodoItem1 = testTodoItem.AddTodo(description1);
            Todo TodoItem2 = testTodoItem.AddTodo(description2);
            Todo TodoItem3 = testTodoItem.AddTodo(description3);
            Todo[] RTodoItem1 = testTodoItem.RemoveToDoItem(TodoItem1);
            //Assert
            Assert.False(Array.Exists(RTodoItem1, element => element == TodoItem1));
            Assert.True(Array.Exists(RTodoItem1, element => element == TodoItem2));
            Assert.True(Array.Exists(RTodoItem1, element => element == TodoItem3));
        }
    }
}
