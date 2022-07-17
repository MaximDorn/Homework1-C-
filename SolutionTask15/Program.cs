// Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Пожалуйста, введите число от 1 до 7: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if(inputNumber == 6 || inputNumber == 7)
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Не выходной");
    }
}