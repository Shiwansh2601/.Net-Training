day3, day4 and day5 are important for project purpose:

(Day 4)

Agenda(most important topics: Delegate, advance generics):

Advance Generics, Delegate, Stack, Heap, value type, Referance type, Garbage Collection
(Delegate , Garbage collection)-> mostally asked in interviews

Major Topics for todays session: Advance Generics, Delegate.
..................................................

We have done the practice of list, dictionary, hashset these are the inbuilt generics now we have to create our own generics 
1. Generic class:

Generic class means if any class end with angular bracket <> and within the angular bracket we can pass formal type (T) and Same T can work for multiple purpose like integer string and etc known as generic class or we can say if any class is said to be generic class we can use for multiple purpose. eg:
Mixy is the best example of generic class, Playground is also a best example of generic class.

2. Generic function

class Employee
{
    public void Leave<T>(T data)
    {
        Console.WriteLine(data);
    }
}
class Office
{
    public static void Main()
    {
        Employee employee = new Employee();
        employee.Leave<string>("2 Days");

        Employee employee1 = new Employee();
        employee1.Leave<int>(25);
    }
        
}

example of non generic funtion: 
class Employee
{
    public void Leave(int data)
    {
        Console.WriteLine(data);
    }
}
class Office
{
    public static void Main()
    {
        Employee employee = new Employee();
        employee.Leave("2 Days");

        Employee employee1 = new Employee();
        employee1.Leave(25);
    }
        
}

If ay function can work on multiple types like i am applying for leave go for integer,someone applying for leave is passing string like 2 days so same function work for multiple type

3. Generic interface

interface IWork<T>
{
    void Task(T a);
}

class Umar : IWork<int>
{
    void IWork<int>.Task(int a)
    {
        Console.WriteLine(a);
    }
}
class Sandeep : IWork<string>
{
    void IWork<string>.Task(string a)
    {
        Console.WriteLine(a);
    }
}

class Office
{
    public static void Main()
    {
        IWork<int> work = new Umar();
        work.Task(25);

        IWork<string> work1 = new Sandeep();
        work1.Task("2 days");


    }
}

Pupose of using generic interface is same interface can be used by multiple programmers over different types which loose coupling.

4. Generic Constraint:Generic means we can fix a type so that T can behave properly(Value type /reference type)
struct -> value type
class ->.reference type


..................................................................

Important topics -> Delegate 







Garbage Collection:
1. In Garbage collection there is finalize (Distructor)

Implementation:

using System;

public class Garbage
{
    int id; //instance variable

    public void Assign(int i)
    {
        id =i;

        Console.WriteLine(id);
    }

}



I want to deallocate the employee class memory from heap(Instantly)

step1:IDisposable is an interface is carrying the function Dispose.
Step2:We have to create an object of Employee class within the (using block)***

Step3: If i do not use using block then the garbage collection will not call to clean the heap memory.




Delegate Introduction:
1.Assume we have the class containing three or four function and i want to expose one or two function to end user a give solution.(Delegate and Function Pointer)

2. Delegate is right persion known as function  pointer in c++,c.
3. Using delegate we can decide which function needs,to expose end user or not.
4. Using delegate we can achieve high end of abstraction.
5. Inbuilt Delegate:
  1. Action delegate
  2. Action delegate 
  3.Predicate delegate


Assignment Day 4:
Day 4 all topics code .






















