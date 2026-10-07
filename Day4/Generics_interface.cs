interface IWork<T>
{

    void Task(T a);

}

class Umar : IWork<int>  // here we can defined the type of interface 
{

    void IWork<int>.Task(int a)  //explicit interface implementation
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

