using System.Collections.Generic;

namespace WPF_Practice.Model;

public class Person
{
    public string? FullName { get; set; }
    public int Age { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public Gender Gender { get; set; }
}

public enum Gender { Male , Female }


public static class PersonRepository
{
    public static List<Person> GetsPerson() 
        => new ()
        {
            new Person{FullName = "Amin" , Age = 23 , Gender = Gender.Male , Height = 181 , Weight = 97},
            new Person{FullName = "Ali" , Age = 23 , Gender = Gender.Male , Height = 174 , Weight = 60},
            new Person{FullName = "Ardalan" , Age = 27 , Gender = Gender.Male , Height = 175 , Weight = 80},
        };
}