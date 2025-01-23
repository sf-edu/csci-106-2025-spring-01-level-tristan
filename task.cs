using System.ComponentModel;
using Microsoft.VisualBasic;


var list = new List<string> {"Name1"};

public class Person
{
    public void NameList()
    {
        var Names = new List<string> {"Name1"};
        Console.WriteLine(Names);
    }
    public double Age;

    public string Name;

    public Person(double age, string name)
    {
        Age = age;
        Name = name;
    }
    
}

public class Dog
{
    public string Name;

    
}