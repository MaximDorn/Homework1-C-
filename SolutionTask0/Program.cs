string? InputLine = Console.ReadLine();

if (InputLine != null)
{
    int InputNumber = int.Parse(InputLine);
    
    //int OutNumber = InputNumber * InputNumber;
    int OutNumber = (int)Math.Pow(InputNumber, 2);
    
    Console.WriteLine(OutNumber);
}