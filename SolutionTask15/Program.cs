// Программа, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным (базовое решение).

Console.WriteLine("Пожалуйста, введите число от 1 до 7: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputNumber = int.Parse(inputLine);
    if(inputNumber == 6 || inputNumber == 7) // Решение через символ "||" (ИЛИ)
    {
        Console.WriteLine(inputNumber + "-й день недели является выходным");
    }
    else
    {
        Console.WriteLine(inputNumber + "-й день недели НЕ является выходным");
    }
}