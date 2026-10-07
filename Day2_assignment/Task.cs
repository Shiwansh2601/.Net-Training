using System;
namespace College
{    class Student
    {   private int rollNo;// Field
        public string Name { get; set; }
        public Student(int rollNo, string name)    // Constructor
        {
            this.rollNo = rollNo;   // this = current object
            Name = name;
        }
        public void Display()  // Method
        {
            Console.WriteLine("Roll No: " + rollNo);
            Console.WriteLine("Name: " + Name);
        }
    }

    class Program
    {        static void Main()
        {  // Object
            Student s = new Student(101, "Shiwansh");
            s.Display();
        }
    }
}