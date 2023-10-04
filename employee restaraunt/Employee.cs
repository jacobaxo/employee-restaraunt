using System;
public class Employee
{
    private int id;
    private string firstName;
    private string lastName;
    private string role;
    private double salary;
    private DateTime dateOfHire;

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string Role
    {
        get { return role; }
        set { role = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public DateTime DateOfHire
    {
        get { return dateOfHire; }
        set { dateOfHire = value; }
    }

    public Employee()
    {
    }

    public Employee(int id, string firstName, string lastName, string role, double salary, DateTime dateOfHire)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Role = role;
        this.Salary = salary;
        this.DateOfHire = dateOfHire;
    }

    public void Promote(double percentage)
    {
        Salary += Salary * (percentage / 100);
    }

    public void Demote(double percentage)
    {
        Salary -= Salary * (percentage / 100);
    }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }
}