string? InputLine = Console.ReadLine();

if (InputLine != null)
{
    int inputNumber = int.Parse(InputLine);
    
    int startNumber = 1;

string lineOutput = "0";

while (startNumber <= inputNumber)
{
lineOutput = startNumber *(-1) + ", "+ lineOutput + ", " + startNumber;
startNumber++;
}

// lineOutput = lineOutput + inputNumber;

    Console.WriteLine(lineOutput);
}