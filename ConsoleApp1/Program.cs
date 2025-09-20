// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("2 + 2 = " + (2 + 2));
public class Person
{
    public string Ten { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Ten = name;
        Age = age;
    }

    public void Introduce()
    {
        Console.WriteLine($"Hello, tôi là {Ten}, {Age} tuổi.");
    }
}

public class Teacher
{
    public string Subject { get; set; }
    public int ExperienceYears { get; set; }

    public Teacher(string subject, int years)
    {
        Subject = subject;
        ExperienceYears = years;
    }

    public void Teach()
    {
        Console.WriteLine($"Tôi dạy môn {Subject} và có {ExperienceYears} năm kinh nghiệm.");
        Console.WriteLine($"Tôí");
        Console.WriteLine("");
    }
}