string? InputLineOne = Console.ReadLine();
string? InputLineTwo = Console.ReadLine();

if (InputLineOne != null && InputLineTwo != null)
{
    int InputNumberOne = int.Parse(InputLineOne);
    int InputNumberTwo = int.Parse(InputLineTwo);
    
    if (InputNumberTwo == Math.Sqrt(InputNumberOne))
    {
        Console.WriteLine("Yes");
    }
    
    else
    {
        Console.WriteLine("No");
    }


}