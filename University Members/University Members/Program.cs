class Person
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Person(string name, string email)
    {
        Name = name;
        Email = email;
        Console.WriteLine("Person Constructor");
    }
    public void DisplayBasicInfo()
    {
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Email : " + Email);
    }
}

class Student : Person
{
    public int StudentId { get; set; }
    public double GPA { get; set; }

    public Student(string name, string email, int studentId, double gpa) : base(name, email)
    {
        StudentId = studentId;
        GPA = gpa;
        Console.WriteLine("Student Constructor");

    }
}

class Employee : Person
{
    public int EmployeeId { get; set; }
    public double Salary { get; set; }
    public Employee(string name, string email, int employeeId, double salary) : base(name, email)
    {
        EmployeeId = employeeId;
        Salary = salary;
        Console.WriteLine("Employee Constructor");


    }

}

class Teacher : Employee
{
    public string CourseName { get; set; }

    public void Teach()
    {
        Console.WriteLine("CourseName : " + CourseName);

    }

    public Teacher(string name, string email, int employeeId, double salary, string coursename) : base(name, email, employeeId, salary)
    {
        CourseName = coursename;
        Console.WriteLine("Teacher Constructor");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Ali", "Ali22.com", 101, 95.8);
        Console.WriteLine("-------------");
        Teacher t1 = new Teacher(" Hussein", "hu9828.com", 202, 2000, "science");
        Console.WriteLine("-------------");

        s1.DisplayBasicInfo();
        Console.WriteLine("Student ID :" + s1.StudentId);
        Console.WriteLine("GPA :" + s1.GPA);

        Console.WriteLine("-------------");

        t1.DisplayBasicInfo();
        Console.WriteLine("Employee ID :" + t1.EmployeeId);
        Console.WriteLine("Salary :" + t1.Salary);
        t1.Teach();


    }
}