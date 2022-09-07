using System.Transactions;
using System;

public class Tamagotchi
{
    int hunger = 10;
    int boredom = 10;
    bool isAlive = true;
    public string name;

    List<string?> words = new();
    Random rdm;

    public void Feed()
    {
        hunger -= 2;
    }

    public void Hi()
    {

    }

    public void Teach()
    {
        Console.WriteLine($"What word would you like to teach {name}?");
        // string? newWord = Console.ReadLine();
        words.Add(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine($"{name} has learnt {words.Last()}!");
        Console.WriteLine("Boredom recuced by 2.");

        ReduceBoredom();
    }

    public void Tick()
    {

    }

    public void Printstats()
    {
        
    }

    public bool getAlive()
    {
        return isAlive;
    }

    void ReduceBoredom()
    {
        boredom -= 2;
    }
}