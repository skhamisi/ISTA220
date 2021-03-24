using System;
using System.Media;

class Liger ///: Animal This is how to inheret a class
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public string Location;

    /// Default Constructor ///
    public Liger()
    {
        Console.WriteLine("Press Any Key to Start\nContinue to Press Any Key to Meet Everyone!\n");
        Console.ReadKey();
        Console.WriteLine("Meet the Liger Family\n");

        Liger lionO = new Liger("LionO", "roar", "Mumra's", "Liger", @"c:\Users\Samer\MSSA2021\Sounds\lion1.wav");
        lionO.Speak();
        Console.ReadKey();
        lionO.PlaySound();
        lionO.Eat();
        Console.ReadKey();
        Console.WriteLine();

    
        Liger panzer = new Liger("Panzer", "roar", "The Krusty Krab", "Liger", @"c:\Users\Samer\MSSA2021\Sounds\lion2.wav");
        panzer.Speak();
        Console.ReadKey();
        panzer.PlaySound();
        panzer.Eat();
        Console.ReadKey();
        Console.WriteLine();

    
        Liger zero = new Liger("Zero", "roar", "The Chum Bucket", "Liger", @"c:\Users\Samer\MSSA2021\Sounds\lion3.wav");
        zero.Speak();
        Console.ReadKey();
        zero.PlaySound();
        zero.Eat();
        Console.ReadKey();
        Console.WriteLine();


        Liger jager = new Liger("Jager", "roar", "McSpanky's", "Liger", @"c:\Users\Samer\MSSA2021\Sounds\lion4.wav");
        jager.Speak();
        Console.ReadKey();
        jager.PlaySound();
        jager.Eat();
        Console.ReadKey();
    }

    /// This constructor initializes my class fields ///
    public Liger(string name, string sound, string food, string type, string location)
    {
        Name = name;
        Sound = sound;
        Food = food;
        Type = type;
        Location = location;
    }

    public void Speak()
    {
        Console.WriteLine($"My name is {Name} and I am a {Type}, hear me {Sound}!");
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
