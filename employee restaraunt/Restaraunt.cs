using System.Collections.Generic;
using System;

public class Restaurant
{
    private List<Employee> employees;

    public Restaurant()
    {
        employees = new List<Employee>();
    }

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void RemoveEmployee(int id)
    {
        Employee employeeToRemove = employees.Find(emp => emp.Id == id);
        if (employeeToRemove != null)
        {
            employees.Remove(employeeToRemove);
            Console.WriteLine("Employee removed successfully.");
        }
        else
        {
            Console.WriteLine("Employee with the specified ID not found.");
        }
    }

    public Employee GetEmployee(int id)
    {
        return employees.Find(emp => emp.Id == id);
    }

    public void DisplayAllEmployees()
    {
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID: {employee.Id}, Name: {employee.FullName()}, Role: {employee.Role}, Salary: {employee.Salary}, Date of Hire: {employee.DateOfHire}");
        }
    }
}
