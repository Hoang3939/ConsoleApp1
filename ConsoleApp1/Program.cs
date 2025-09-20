// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("1 + 1 = " + (1 + 1));
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Xin chào, tôi là {Name}, {Age} tuổi.");
    }
}

public class Student
{
    public string Major { get; set; }
    public int StudentId { get; set; }

    public void Introduce()
    {
        Console.WriteLine($"Tôi là sinh viên có mã số {StudentId}, chuyên ngành {Major}.");
    }
}