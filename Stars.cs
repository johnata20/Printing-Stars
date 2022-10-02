int inp;

Console.Write("Enter a number : ");
inp = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

for (int x = 0; x < inp; x++)
{
    for (int y = 0; y < x; y++)
        Console.Write("*");
    Console.WriteLine("*");
}

Console.WriteLine();
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
