using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Student : Person
    {
        protected string group;
        protected List<Task> tasks;
       
        public string Group { get; set; }

        public Student(string name, int age, string group) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.group = group;
        }
        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.name = name;
            this.age = age;
            this.group = group;
            this.tasks = tasks;
        }
        public void AddTask ( string name, TaskStatus status) 
        {
           
          tasks = new Task(name, status);
            tasks.Add(Task);
        }
        public void RemoveTask(int index)
        {
            return.task;
        }
    }
       
}
