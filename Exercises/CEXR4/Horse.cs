using System;
using System.Media;

public class Horse
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public string Location;

    /// Default Constructor ///
    public Horse()
    {
        Console.WriteLine("Meet the Horse Family\n");

        Horse wingedDragonRa = new Horse("Ra the Dragon", "neigh", "Texas Road House", "Horse", @"c:\Users\Samer\MSSA2021\Sounds\horse1.wav");
        wingedDragonRa.Speak();
        Console.ReadKey();
        wingedDragonRa.PlaySound();
        wingedDragonRa.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Horse blueEyes = new Horse("Blue Eyes", "neigh", "Longhorn Steak House", "Horse", @"c:\Users\Samer\MSSA2021\Sounds\horse2.wav");
        blueEyes.Speak();
        Console.ReadKey();
        blueEyes.PlaySound();
        blueEyes.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Horse obelisk = new Horse("Obelisk", "neigh", "Texas Land & Cattle", "Horse", @"c:\Users\Samer\MSSA2021\Sounds\horse3.wav");
        obelisk.Speak();
        Console.ReadKey();
        obelisk.PlaySound();
        obelisk.Eat();
        Console.ReadKey();
        Console.WriteLine();

        Horse slifer = new Horse("Slifer", "neigh", "Steak 'n Shake", "Horse", @"c:\Users\Samer\MSSA2021\Sounds\horse4.wav");
        slifer.Speak();
        Console.ReadKey();
        slifer.PlaySound();
        slifer.Eat();
        Console.ReadKey();
    }

    /// This constructor initializes my class fields ///
    public Horse(string name, string sound, string food, string type, string location)
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
        Console.WriteLine($"I like to eat at {Food}");
    }

    public void PlaySound()
    {
        var player = new SoundPlayer();
        player.SoundLocation = Location;
        player.PlaySync();
    }
}

