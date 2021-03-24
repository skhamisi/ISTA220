using System;
using System.Media;

public class Monkey
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public string Location;

    /// Default Constructor ///
    public Monkey()
    {
        Console.WriteLine("Meet the Monkey Family\n");

        Monkey rambo = new Monkey("Rambo", "scream", "Jimmy John's", "Ape", @"c:\Users\Samer\MSSA2021\Sounds\monkey1.wav");
        rambo.Speak();
        Console.ReadKey();
        rambo.PlaySound();
        rambo.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Monkey arnold = new Monkey("Arnold", "scream", "Subway", "Ape", @"c:\Users\Samer\MSSA2021\Sounds\monkey2.wav");
        arnold.Speak();
        Console.ReadKey();
        arnold.PlaySound();
        arnold.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Monkey sylvester = new Monkey("Sylvester", "scream", "Wendy's", "Ape", @"c:\Users\Samer\MSSA2021\Sounds\monkey3.wav");
        sylvester.Speak();
        Console.ReadKey();
        sylvester.PlaySound();
        sylvester.Eat();
        Console.ReadKey();
        Console.WriteLine();

        Monkey uSAF = new Monkey("USAF", "scream", "Morale", "Ape", @"c:\Users\Samer\MSSA2021\Sounds\monkey4.wav");
        uSAF.Speak();
        Console.ReadKey();
        uSAF.PlaySound();
        uSAF.Eat();
        Console.ReadKey();
    }

    /// This constructor initializes my class fields ///
    public Monkey(string name, string sound, string food, string type, string location)
    {
        Name = name;
        Sound = sound;
        Food = food;
        Type = type;
        Location = location;
    }

    public void Speak()
    {
        Console.WriteLine($"My name is {Name} and I am an {Type}, hear me {Sound}!"); ;
    }

    public void Eat()
    {
        Console.WriteLine($"I like to eat {Food}");
    }

    public void PlaySound()
    {
        var player = new SoundPlayer();
        player.SoundLocation = Location;
        player.PlaySync();
    }
}

