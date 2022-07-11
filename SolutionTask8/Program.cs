string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    
    int startNumber = 2;

string lineOutput = "";

if(inputNumber <=1)

{
    Console.WriteLine("Введённое значение должно быть > 1");
}

else

{
    while (startNumber < inputNumber-1)
    {
    lineOutput = lineOutput + startNumber + ", ";
    startNumber = startNumber + 2;
    }

        lineOutput = lineOutput + startNumber;
       
        Console.WriteLine(lineOutput);
}

}