const int NumberOfNumbers = 10;
int[] numbers = new int[NumberOfNumbers];

Console.WriteLine($"==== Even getallen uit {NumberOfNumbers} getallen tonen. ====\r\n\r\n");
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Geef getal {i + 1}/{numbers.Length} : ");
    bool isSucceeded = int.TryParse(Console.ReadLine(), out numbers[i]);
    if (!isSucceeded)
    {
        Console.WriteLine("Geef een getal in.");
        Console.ReadLine();
        return;
    }
    Console.WriteLine();
}

Console.WriteLine("==== Even getallen afdrukken. ====\r\n");
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine($"Getal {i + 1} is een even getal : {numbers[i]}");
    }
}

Console.ReadLine();