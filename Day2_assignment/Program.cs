using System;

class EmployeeService
{
    static decimal CalculateSalary(decimal basicSalary, decimal bonus)
    {
        return basicSalary + bonus;
    }
    static decimal CalculateSalary(decimal basicSalary, decimal bonus, decimal tax)
    {
        return basicSalary + bonus - tax;
    }

    // Method Overloading
    static decimal CalculateSalary(int basicSalary, int bonus)
    {
        return basicSalary + bonus;
    }

    // ref parameter
  
    static void ApplyBonus(ref decimal salary, decimal bonus)
    {
        salary = salary + bonus;
    }

    // out parameter
    
    static bool CheckEmployee(int employeeId, out string employeeName)
    {
        if (employeeId == 101)
        {
            employeeName = "Rahul";
            return true;
        }

        employeeName = "Employee Not Found";
        return false;
    }

    // in parameter
    static void PrintSalary(in decimal salary)
    {
        Console.WriteLine($"Current Salary: {salary}");
    }
    static void Main()
    {
        decimal salary = CalculateSalary(50000m, 5000m);   // Normal parameters
        Console.WriteLine($"Salary: {salary}");
        
        // METHOD OVERLOADING
        decimal salary1 = CalculateSalary(50000m, 5000m);
        decimal salary2 = CalculateSalary(50000m, 5000m, 3000m);
        decimal salary3 = CalculateSalary(50000, 5000);

        Console.WriteLine($"Overload 1: {salary1}");
        Console.WriteLine($"Overload 2: {salary2}");
        Console.WriteLine($"Overload 3: {salary3}");
        // ref PARAMETER
        decimal employeeSalary = 50000m;
        Console.WriteLine($"Before Bonus: {employeeSalary}");
        ApplyBonus(ref employeeSalary, 5000m);
        Console.WriteLine($"After Bonus: {employeeSalary}");
        // out PARAMETER
        string employeeName;

        bool found = CheckEmployee(101, out employeeName);
        Console.WriteLine($"Employee Found: {found}");
        Console.WriteLine($"Employee Name: {employeeName}");
        // in PARAMETE
        PrintSalary(in employeeSalary);
    }
}