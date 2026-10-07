 // Creating own generics where T(we can give any name )is a formal type.

 class Employee<T>
{
    public void EmployeeAddress(T ctr)
    {
        Console.WriteLine(ctr);
    }
}

/* class Office
{
    public static void Main()
    {
        Employee<string> empstr=new Employee<string>(); // Generic class object creation for string type

        empstr.EmployeeAddress("prayagraj");

         
         
         Employee<int> empint=new Employee<int>(); // Generic class object creation for int type

        empint.EmployeeAddress(125);


        Employee<float> empfloat=new Employee<float>(); // Generic class object creation for float type

        empfloat.EmployeeAddress(125.55);

    }
} */