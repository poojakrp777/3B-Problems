using System;

public class Employee
{
    public Employee()
    {
        Console.WriteLine("Default Constructor Invoked");
    }
    public int id;
    public String name;
    public float salary;
    public Employee(int i, String n, float s)
    {
        id = i;
        name = n;
        salary = s;
    }
    public void display()
    {
        Console.WriteLine(id + " " + name + " " + salary);
    }
}