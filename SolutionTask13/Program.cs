// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Пожалуйста, введите число: ");
string? inputNumber = Console.ReadLine();

if (inputNumber != null)
{
    int inputNumberOne = int.Parse(inputNumber);
    Char[] array = inputNumber.ToCharArray(); // Преобразование введённой строки в массив методом "ToCharArray"
    if (array.Length > 2) // Проверка наличия третьей цифры (длина массива > 2)
    {
        Console.WriteLine(array[2]);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}