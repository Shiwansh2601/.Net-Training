using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Test
{
    static void Main()
    {
        // =========================================================
        // EMPLOYEE DATA
        // =========================================================

        List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                Id = 1,
                Name = "Rahul",
                Age = 25,
                Department = "IT",
                Salary = 50000
            },

            new Employee
            {
                Id = 2,
                Name = "Priya",
                Age = 28,
                Department = "HR",
                Salary = 60000
            },

            new Employee
            {
                Id = 3,
                Name = "Amit",
                Age = 22,
                Department = "IT",
                Salary = 40000
            },

            new Employee
            {
                Id = 4,
                Name = "Neha",
                Age = 30,
                Department = "Finance",
                Salary = 75000
            },

            new Employee
            {
                Id = 5,
                Name = "Ravi",
                Age = 26,
                Department = "IT",
                Salary = 65000
            }
        };


        // =========================================================
        // 1. WHERE()
        // =========================================================
        // WHERE is used to FILTER records.
        //
        // SQL equivalent:
        // SELECT * FROM Employees WHERE Salary > 50000;

        IEnumerable<Employee> highSalaryEmployees =
            employees.Where(e => e.Salary > 50000);

        foreach (Employee employee in highSalaryEmployees)
        {
            Console.WriteLine(employee.Name);
        }


        // =========================================================
        // 2. WHERE() WITH MULTIPLE CONDITIONS
        // =========================================================
        // Get employees who:
        // Department = IT
        // AND Salary > 50000

        IEnumerable<Employee> itEmployees =
            employees.Where(e =>
                e.Department == "IT" &&
                e.Salary > 50000);

        foreach (Employee employee in itEmployees)
        {
            Console.WriteLine(employee.Name);
        }


        // =========================================================
        // 3. SELECT()
        // =========================================================
        // SELECT is used for PROJECTION.
        //
        // Instead of getting complete Employee objects,
        // we only select the employee names.

        IEnumerable<string> employeeNames =
            employees.Select(e => e.Name);

        foreach (string name in employeeNames)
        {
            Console.WriteLine(name);
        }


        // =========================================================
        // 4. SELECT() MULTIPLE PROPERTIES
        // =========================================================
        // We can create a new object containing only required data.
        //
        // This is very common when preparing API response data.

        var employeeDetails =
            employees.Select(e => new
            {
                e.Name,
                e.Department,
                e.Salary
            });

        foreach (var employee in employeeDetails)
        {
            Console.WriteLine(
                employee.Name + " " +
                employee.Department + " " +
                employee.Salary);
        }


        // =========================================================
        // 5. WHERE() + SELECT()
        // =========================================================
        // Get names of employees whose salary is greater than 50000.

        IEnumerable<string> selectedEmployees =
            employees
                .Where(e => e.Salary > 50000)
                .Select(e => e.Name);

        foreach (string name in selectedEmployees)
        {
            Console.WriteLine(name);
        }


        // =========================================================
        // 6. ORDERBY()
        // =========================================================
        // Sort employees by salary in ASCENDING order.

        IOrderedEnumerable<Employee> salaryAscending =
            employees.OrderBy(e => e.Salary);

        foreach (Employee employee in salaryAscending)
        {
            Console.WriteLine(
                employee.Name + " : " + employee.Salary);
        }


        // =========================================================
        // 7. ORDERBYDESCENDING()
        // =========================================================
        // Sort employees by salary in DESCENDING order.

        IOrderedEnumerable<Employee> salaryDescending =
            employees.OrderByDescending(e => e.Salary);

        foreach (Employee employee in salaryDescending)
        {
            Console.WriteLine(
                employee.Name + " : " + employee.Salary);
        }


        // =========================================================
        // 8. THENBY()
        // =========================================================
        // First sort by Department.
        // If two employees have the same department,
        // then sort them by Name.

        IOrderedEnumerable<Employee> departmentThenName =
            employees
                .OrderBy(e => e.Department)
                .ThenBy(e => e.Name);

        foreach (Employee employee in departmentThenName)
        {
            Console.WriteLine(
                employee.Department + " : " +
                employee.Name);
        }


        // =========================================================
        // 9. THENBYDESCENDING()
        // =========================================================
        // First sort by Department.
        // Inside each department, sort salary DESCENDING.

        IOrderedEnumerable<Employee> departmentThenSalary =
            employees
                .OrderBy(e => e.Department)
                .ThenByDescending(e => e.Salary);

        foreach (Employee employee in departmentThenSalary)
        {
            Console.WriteLine(
                employee.Department + " : " +
                employee.Name + " : " +
                employee.Salary);
        }


        // =========================================================
        // 10. FIRST()
        // =========================================================
        // Returns the FIRST matching element.
        //
        // If no element is found, First() throws an exception.

        Employee firstITEmployee =
            employees.First(e => e.Department == "IT");

        Console.WriteLine(firstITEmployee.Name);


        // =========================================================
        // 11. FIRSTORDEFAULT()
        // =========================================================
        // Returns the first matching employee.
        //
        // If no employee exists, it returns null
        // instead of throwing an exception.

        Employee employeeFound =
            employees.FirstOrDefault(e => e.Id == 10);

        if (employeeFound != null)
        {
            Console.WriteLine(employeeFound.Name);
        }
        else
        {
            Console.WriteLine("Employee not found");
        }


        // =========================================================
        // 12. SINGLE()
        // =========================================================
        // SINGLE means:
        // "I expect exactly ONE matching record."
        //
        // Id is unique, so this is suitable here.

        Employee singleEmployee =
            employees.Single(e => e.Id == 3);

        Console.WriteLine(singleEmployee.Name);


        // =========================================================
        // 13. SINGLEORDEFAULT()
        // =========================================================
        // Returns one matching record.
        //
        // If no record exists, returns null.
        //
        // If MORE THAN ONE record matches, it throws an exception.

        Employee? optionalEmployee =
            employees.SingleOrDefault(e => e.Id == 10);

        if (optionalEmployee != null)
        {
            Console.WriteLine(optionalEmployee.Name);
        }
        else
        {
            Console.WriteLine("Employee not found");
        }


        // =========================================================
        // 14. ANY()
        // =========================================================
        // Checks whether AT LEAST ONE record exists.
        //
        // Very common in real projects.

        bool hasHighSalaryEmployee =
            employees.Any(e => e.Salary > 70000);

        Console.WriteLine(hasHighSalaryEmployee);


        // =========================================================
        // 15. ALL()
        // =========================================================
        // Checks whether ALL employees satisfy a condition.

        bool allAdults =
            employees.All(e => e.Age >= 18);

        Console.WriteLine(allAdults);


        // =========================================================
        // 16. COUNT()
        // =========================================================
        // Counts total number of employees.

        int totalEmployees =
            employees.Count();

        Console.WriteLine(totalEmployees);


        // =========================================================
        // 17. COUNT() WITH CONDITION
        // =========================================================
        // Count employees working in IT.

        int itEmployeeCount =
            employees.Count(e => e.Department == "IT");

        Console.WriteLine(itEmployeeCount);


        // =========================================================
        // 18. SUM()
        // =========================================================
        // Calculate total salary of all employees.

        double totalSalary =
            employees.Sum(e => e.Salary);

        Console.WriteLine(totalSalary);


        // =========================================================
        // 19. AVERAGE()
        // =========================================================
        // Calculate average salary.

        double averageSalary =
            employees.Average(e => e.Salary);

        Console.WriteLine(averageSalary);


        // =========================================================
        // 20. MIN()
        // =========================================================
        // Find minimum salary.

        double minimumSalary =
            employees.Min(e => e.Salary);

        Console.WriteLine(minimumSalary);


        // =========================================================
        // 21. MAX()
        // =========================================================
        // Find maximum salary.

        double maximumSalary =
            employees.Max(e => e.Salary);

        Console.WriteLine(maximumSalary);


        // =========================================================
        // 22. GROUPBY()
        // =========================================================
        // Group employees according to their department.
        //
        // Very important for reports and dashboards.

        IEnumerable<IGrouping<string, Employee>> groups =
            employees.GroupBy(e => e.Department);

        foreach (IGrouping<string, Employee> group in groups)
        {
            Console.WriteLine("Department: " + group.Key);

            foreach (Employee employee in group)
            {
                Console.WriteLine(employee.Name);
            }
        }


        // =========================================================
        // 23. GROUPBY() + COUNT()
        // =========================================================
        // Count employees in each department.
        //
        // Similar to SQL:
        //
        // SELECT Department, COUNT(*)
        // FROM Employees
        // GROUP BY Department;

        var departmentCounts =
            employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    EmployeeCount = g.Count()
                });

        foreach (var result in departmentCounts)
        {
            Console.WriteLine(
                result.Department + " : " +
                result.EmployeeCount);
        }


        // =========================================================
        // 24. GROUPBY() + AVERAGE()
        // =========================================================
        // Find average salary of each department.

        var departmentAverageSalary =
            employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    AverageSalary = g.Average(e => e.Salary)
                });

        foreach (var result in departmentAverageSalary)
        {
            Console.WriteLine(
                result.Department + " : " +
                result.AverageSalary);
        }


        // =========================================================
        // 25. GROUPBY() + SUM()
        // =========================================================
        // Calculate total salary expenditure
        // for each department.

        var departmentTotalSalary =
            employees
                .GroupBy(e => e.Department)
                .Select(g => new
                {
                    Department = g.Key,
                    TotalSalary = g.Sum(e => e.Salary)
                });

        foreach (var result in departmentTotalSalary)
        {
            Console.WriteLine(
                result.Department + " : " +
                result.TotalSalary);
        }


        // =========================================================
        // 26. DISTINCT()
        // =========================================================
        // Get unique department names.

        IEnumerable<string> uniqueDepartments =
            employees
                .Select(e => e.Department)
                .Distinct();

        foreach (string department in uniqueDepartments)
        {
            Console.WriteLine(department);
        }


        // =========================================================
        // 27. CONTAINS()
        // =========================================================
        // Check whether a particular value exists
        // in a collection.

        List<string> departments =
            employees
                .Select(e => e.Department)
                .Distinct()
                .ToList();

        bool hasIT =
            departments.Contains("IT");

        Console.WriteLine(hasIT);


        // =========================================================
        // 28. SKIP()
        // =========================================================
        // Skip the first N records.
        //
        // Useful for pagination.

        IEnumerable<Employee> skippedEmployees =
            employees.Skip(2);

        foreach (Employee employee in skippedEmployees)
        {
            Console.WriteLine(employee.Name);
        }


        // =========================================================
        // 29. TAKE()
        // =========================================================
        // Take only the first N records.

        IEnumerable<Employee> firstThreeEmployees =
            employees.Take(3);

        foreach (Employee employee in firstThreeEmployees)
        {
            Console.WriteLine(employee.Name);
        }


        // =========================================================
        // 30. SKIP() + TAKE()
        // =========================================================
        // This is one of the most important pagination patterns.
        //
        // Example:
        // Page 1 -> records 1 to 2
        // Page 2 -> records 3 to 4
        // Page 3 -> record 5

        int pageNumber = 2;
        int pageSize = 2;

        List<Employee> pageData =
            employees
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();

        foreach (Employee employee in pageData)
        {
            Console.WriteLine(employee.Name);
        }


        // =========================================================
        // 31. TOLIST()
        // =========================================================
        // Converts LINQ result into List<Employee>.

        List<Employee> highSalaryList =
            employees
                .Where(e => e.Salary > 50000)
                .ToList();

        Console.WriteLine(highSalaryList.Count);


        // =========================================================
        // 32. TODICTIONARY()
        // =========================================================
        // Converts collection into Dictionary.
        //
        // Key   = Employee Id
        // Value = Employee object

        Dictionary<int, Employee> employeeDictionary =
            employees.ToDictionary(e => e.Id);

        Employee employeeFromDictionary =
            employeeDictionary[3];

        Console.WriteLine(employeeFromDictionary.Name);


        // =========================================================
        // 33. SELECTMANY()
        // =========================================================
        // Used to FLATTEN nested collections.
        //
        // Example:
        //
        // Employee 1 -> C#, SQL
        // Employee 2 -> Java, React
        //
        // SelectMany gives:
        //
        // C#, SQL, Java, React

        // This requires an Employee class with a Skills
        // collection, so it is shown conceptually here.


        // =========================================================
        // 34. A REAL PROJECT-STYLE LINQ QUERY
        // =========================================================
        // Requirement:
        //
        // Get IT employees
        // whose salary is greater than 45000,
        // sort by highest salary,
        // return only Name and Salary.

        var projectResult =
            employees
                .Where(e =>
                    e.Department == "IT" &&
                    e.Salary > 45000)
                .OrderByDescending(e => e.Salary)
                .Select(e => new
                {
                    e.Name,
                    e.Salary
                })
                .ToList();

        foreach (var employee in projectResult)
        {
            Console.WriteLine(
                employee.Name + " : " +
                employee.Salary);
        }
    }
}