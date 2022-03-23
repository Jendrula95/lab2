using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    internal class Classroom
    {
        private string name;
        private Person[] person;
        public string  Name { get { return name; } }
        public Classroom(string name, Person[] person)
        {
            this.name = name;
            this.person = person;
        }
        public override string ToString()
        {
            string results = "Classroom : " + this.name + "\n\n";
            foreach (Person p in person)
            {
                results += results + p.ToString();
            }
            return results;
        }
    }
    
}
