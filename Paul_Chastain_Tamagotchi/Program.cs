
Tamagotchi tama = new();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Welcome to some random Tamagotchi game!");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("What would you like to call your Tamagotchi?");
tama.name = Console.ReadLine();

Console.WriteLine($"Say hi to {tama.name}!");
Console.WriteLine();

Console.WriteLine($"What would you like to do with {tama.name}? (Press a number, ? to ?, to select what to do.)");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("1. Say Hi!");
Console.WriteLine("2. Print stats");
Console.WriteLine("3. Teach");
Console.WriteLine("4. Feed (Reduces hunger by 2)");
Console.WriteLine($"5. Play with {tama.name}");



Console.ReadLine();