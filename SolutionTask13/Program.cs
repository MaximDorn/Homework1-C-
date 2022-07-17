// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Пожалуйста, введите число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    char[] array = inputNumber.ToCharArray(); // Конвертация введённой строки в массив методом "ToCharArray"
    if (array.Length > 2) // Проверка наличия третьей цифры (длина массива > 2)
    {
        Console.WriteLine("Третья цифра числа: " + array[2]); // "array[2]", потому что отчёт в массиве ведётся с индекса "0"
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}