using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
    class Person : IEquatable<Person>
    {
        protected string name;
        protected int age;

        public string Name { get; set; }
        public int Age { get; set; }
       

        public Person ( string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public bool Equals(Person other)
        {
            if (other == null) return false;
            if (other == this) return true; // jeśli other i this wskazują na te same obiekty w pamięci - porównanie typów referencyjnych

            return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
        }
        public override string ToString()
        {
            return $"{name},{age} y.o";
        }
    }


}

