using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Person");
    }
}

class Student : Person
{
    public int StudentId { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("Student");
    }
}

class Employee : Person
{
    public double Salary { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("Salary");
    }
}

class Teacher : Employee
{
    public string CourseName { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("CourseName");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> person = new List<Person>
        {
            new Student { Name = "ali ", StudentId = 22 },
            new Employee { Name = " kild ", Salary = 333 },
            new Teacher { Name = "lll", CourseName = "math" }
        };

        foreach (Person person1 in person)
        {
            Console.WriteLine(person1.GetType());
            person1.DisplayInfo();
        }

        Student s = new Student { Name = "hussin ", StudentId = 29 };
        PrintPerson(s);

        Console.ReadLine();
    }

    public static void PrintPerson(Person p)
    {
        p.DisplayInfo();
    }
}