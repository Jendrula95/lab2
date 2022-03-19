using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Teacher : Person
    {
        public Teacher (string name,int age) : base(name, age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
