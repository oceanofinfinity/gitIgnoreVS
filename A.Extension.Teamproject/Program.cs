using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Extension.Teamproject
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = new CircularBuffer<double>(capacity : 3);

            var employees = new List<Employee>
            {
                new Employee { Name ="A"},
                new Employee {Name = "B" }
            };

            foreach (var emp in employees)
            {
                Console.WriteLine(emp.Name);
            }

            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].Name);
            }
            Console.Read();
        }
    }

    public class Employee
    {
        public string Name { get; set; }

    }

    public class CircularBuffer<T>
    {

        private T[] _buffer;
        private int _start;
        private int _end;

        public CircularBuffer():this(capacity:10)
        {

        }

        public CircularBuffer( int capacity)
        {
            _buffer = new T[capacity + 1];
            _start = 0;
            _end = 0;

        }
    }
}
