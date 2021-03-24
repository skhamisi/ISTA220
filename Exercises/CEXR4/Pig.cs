using System;
using System.Media;

public class Pig
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public string Location;

    /// Default Constructor ///
    public Pig()
    {
        Console.WriteLine("Meet the Pig Family\n");

        Pig voltron = new Pig("Voltron", "squeal", "Whataburger", "Pig", @"c:\Users\Samer\MSSA2021\Sounds\pig1.wav");
        voltron.Speak();
        Console.ReadKey();
        voltron.PlaySound();
        voltron.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Pig megaBorg = new Pig("MegaBorg", "squeal", "Schlotzsky's", "Pig", @"c:\Users\Samer\MSSA2021\Sounds\pig2.wav");
        megaBorg.Speak();
        Console.ReadKey();
        megaBorg.PlaySound();
        megaBorg.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Pig megaZord = new Pig("MegaZord", "squeal", "Quiznos", "Pig", @"c:\Users\Samer\MSSA2021\Sounds\pig3.wav");
        megaZord.Speak();
        Console.ReadKey();
        megaZord.PlaySound();
        megaZord.Eat();
        Console.ReadKey();
        Console.WriteLine();

        Pig bigO = new Pig("BigO", "scream", "squeal", "McDonald's", @"c:\Users\Samer\MSSA2021\Sounds\pig4.wav");
        bigO.Speak();
        Console.ReadKey();
        bigO.PlaySound();
        bigO.Eat();
        Console.ReadKey();
    }

    /// This constructor initializes my class fields ///
    public Pig(string name, string sound, string food, string type, string location)
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

