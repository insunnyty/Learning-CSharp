using System;

namespace _08_classes;

public class Animal
{
    public string size;
    public string species;
    public string name;
    public string age;

    public Animal(string animalName)
    {
        name = animalName;
        Console.WriteLine($"Object Animal {name} has been created.");
    }

    public void Eat()
    {
        Console.WriteLine($"{name} is eating.");
    }

    public int Move()
    {
        Console.WriteLine($"{name} is moving...");
        if (size == "small")
        {
            return 5;
        }
        else if (size == "medium")
        {
            return 10;
        }
        else if (size == "large")
        {
            return 15;
        }
        else
        {
            return 0;
        }
    }

    public void Play(Animal other)
    {
        Console.WriteLine($"{name} is playing with {other.name}");
    }

    public void Print()
    {
        
    Console.WriteLine($"""

    Animal:
    - Name: {name}
    - Species: {species}
    - Size: {size}
    - Age: {age}

    """);

    }
}



