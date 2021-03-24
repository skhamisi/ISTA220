using System;
using System.Media;

public class Animal
{
    public string Name;
    public string Sound;
    public string Food;
    public string Type;
    public string Location;

    public Animal(string name, string sound, string food, string type, string location)
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

