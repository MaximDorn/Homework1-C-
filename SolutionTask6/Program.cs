string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    
    int Test = inputNumber%2;

    if (Test == 0)
    {
        Console.WriteLine("Число является чётным");
    }

    else
    {
        Console.WriteLine("Число является нечётным");
    }



    
}