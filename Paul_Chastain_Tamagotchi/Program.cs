
Tamagotchi tama1 = new();
Tamagotchi tama2 = new();
Tamagotchi tama3 = new();

int selected = 0;


Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome to some random Tamagotchi game!");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine("What would you like to do?");
Console.WriteLine();
Console.WriteLine();

do
{
    Console.CursorTop = 5;
    Console.WriteLine($"  Tamagotchi 1 - {tama1.name}");
    Console.WriteLine($"  Tamagotchi 2 - {tama2.name}");
    Console.WriteLine($"  Tamagotchi 3 - {tama3.name}");

    Console.CursorVisible = false;
    Console.CursorLeft = 0;
    Console.CursorTop = 5 + selected;
    Console.Write(">");

    ConsoleKey key = Console.ReadKey().Key;
    if (key == ConsoleKey.DownArrow)
    {
        selected++;
        if (selected == 3) { selected = 0; }
    } 
    else if(key == ConsoleKey.UpArrow)
    {
        selected--;
        if (selected == -1) { selected = 2; }
    }


} while (true);

    // input här
    // Flytta cursor till nuvarande plats
    // Skriv ut mellanslag
    // ändra värde på currentPlace


Console.ReadLine();
