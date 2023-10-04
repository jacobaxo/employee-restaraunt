using System;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();

        Employee employee1 = new Employee(1, "Joe", "Doe", "Waitstaff", 25000, DateTime.Parse("2020-02-25"));
        Employee employee2 = new Employee(2, "Jobe", "Daniels", "Chef", 40000, DateTime.Parse("2019-06-17"));
        Employee employee3 = new Employee(1, "rock", "Stone", "Chef", 60000, DateTime.Parse("2010-02-04"));
        Employee employee4 = new Employee(2, "Jobe", "Daniels", "Chef", 80000, DateTime.Parse("2009-08-15"));
        restaurant.AddEmployee(employee1);
        restaurant.AddEmployee(employee2);
        restaurant.AddEmployee(employee3);
        restaurant.AddEmployee(employee4);


        Console.WriteLine("All Employees:");
        restaurant.DisplayAllEmployees();

        employee1.Promote(10);
        Console.WriteLine("\nAfter Promotion:");
        restaurant.DisplayAllEmployees();

        employee2.Demote(5);
        Console.WriteLine("\nAfter Demotion:");
        restaurant.DisplayAllEmployees();

        restaurant.RemoveEmployee(1);
        Console.WriteLine("\nAfter Removing Employee:");
        restaurant.DisplayAllEmployees();
    }
}