
using System;
using System.Collections.Generic;

public class Employee
{
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string PhoneNumber { get; set; }

    public Employee(int id, string name, string phone)
    {
        EmployeeId = id;
        EmployeeName = name;
        PhoneNumber = phone;
    }
}

public class HR
{
    private  List<Employee> employees = new();

    // Create
    public void AddEmployee(Employee employee)
    {
        if (employees.Exists(e => e.EmployeeId == employee.EmployeeId))
        {
            Console.WriteLine("Employee ID already exists.");
            return;
        }

        employees.Add(employee);
        Console.WriteLine("Employee added successfully.");
    }

    // Read
    public void SearchEmployee(int id)
    {
        Employee? employee = employees.Find(e => e.EmployeeId == id);

        if (employee == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        DisplayEmployee(employee);
    }

    // Update
    public void UpdateEmployee(int id, string newName)
    {
        Employee? employee = employees.Find(e => e.EmployeeId == id);

        if (employee == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        employee.EmployeeName = newName;
        Console.WriteLine("Employee updated successfully.");
    }

    // Delete
    public void DeleteEmployee(int id)
    {
        Employee? employee = employees.Find(e => e.EmployeeId == id);

        if (employee == null)
        {
            Console.WriteLine("Employee not found.");
            return;
        }

        employees.Remove(employee);
        Console.WriteLine("Employee deleted successfully.");
    }

    // Display all employees
    public void ShowEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees available.");
            return;
        }

        foreach (Employee employee in employees)
        {
            DisplayEmployee(employee);
        }
    }

    private static void DisplayEmployee(Employee employee)
    {
        Console.WriteLine(
            $"ID: {employee.EmployeeId}, " +
            $"Name: {employee.EmployeeName}, " +
            $"Phone: {employee.PhoneNumber}"
        );
    }
}

public class Program
{
    public static void Main()
    {
        HR hr = new HR();

        hr.AddEmployee(new Employee(101, "Shiwansh", "1453"));
        hr.AddEmployee(new Employee(102, "Sakshi", "2234"));
        hr.AddEmployee(new Employee(103, "Suresh", "224"));
        hr.AddEmployee(new Employee(104, "Charan", "2256"));

        Console.WriteLine("\nAll Employees:");
        hr.ShowEmployees();

        Console.WriteLine("\nSearch Employee:");
        hr.SearchEmployee(102);

        Console.WriteLine("\nUpdate Employee:");
        hr.UpdateEmployee(102, "Sakshi Shukla");

        Console.WriteLine("\nDelete Employee:");
        hr.DeleteEmployee(103);

        Console.WriteLine("\nFinal Employee List:");
        hr.ShowEmployees();
    }
}
