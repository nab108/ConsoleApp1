int p1HP = 100;
int p2HP = 100;

string p1Name = "Alex";
string p2Name = "Calin";

while (p1HP > 0 && p2HP > 0)
{
    Console.WriteLine($"{p1Name}: {p1HP}");
    Console.WriteLine($"{p2Name}: {p2HP}");
    p2HP -= Random.Shared.Next(10, 25); // Alex slår Calin
    p1HP -= Random.Shared.Next(10, 25); // Calin slår Alex
    Thread.Sleep(1000);
}
    if (p1HP > 0)
    {
        Console.WriteLine($"{p1Name} vann!");
    }
    else if (p1HP <= 0 && p2HP <= 0)
    {
        Console.WriteLine("Oavgjort!");
    }

    else
    {
        Console.WriteLine($"{p2Name} vann!");
    }


    Console.ReadLine();




