string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    
    if (inputNumberA > inputNumberB)
    {
        Console.WriteLine(inputNumberA + ">" + inputNumberB + "  -->" + "  Max="+ inputNumberA +", " + "Min="+ inputNumberB);
    }
    
    else
    {
        Console.WriteLine(inputNumberB + ">" + inputNumberA + "  -->" + "  Max="+ inputNumberB +", " + "Min="+ inputNumberA);
    }
    
}