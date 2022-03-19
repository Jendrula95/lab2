using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{
     enum TaskStatus
    {
        Waiting,
            Progress,
            Done,
            Rejected
    }
    class Task : IEnumerable<Task>
    {
        private string name;
        private TaskStatus status;
        public string Name { get; set; }
        public string TaskStatus { get; set; }
        public bool Equals(Task other)
        {
            if (other == null) return false;
            if (other == this) return true; // jeśli other i this wskazują na te same obiekty w pamięci - porównanie typów referencyjnych

            return Object.Equals(this.name, other.name) && Object.Equals(this.age, other.age);
        }
        public override string ToString()
        {
            return $"{name},{TaskStatus}";
        }
    }
}
