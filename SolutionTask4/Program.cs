string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    
    int Max = inputNumberA;

    if (inputNumberB > Max)
    {
        Max = inputNumberB;
    }
    
    if (inputNumberC > Max)
    {
        Max = inputNumberC;
    }

Console.WriteLine("Максимальное значение =" + " " + Max);

}