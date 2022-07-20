// Программа, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

Console.WriteLine("Пожалуйста, введите пятизначное число: ");
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    char[] array = inputLine.ToCharArray(); // Конвертация введённой строки в массив методом "ToCharArray"
    if (array.Length == 5) // Проверка на то, что ввели именно пятизначное число
    {
        palendromCheck(); // Вызов метода, проверяющего пятизначное число на палиндром
    }
    else
    {
        Console.WriteLine("Введено не пятизначное число: необходимо повторить ввод!");
    }
}
void palendromCheck() // Метод, проверяющий пятизначное число на палиндром
        {
            int D = int.Parse(inputLine);
            int D1 = D / 10000;
            int D2 = (D / 1000) % 10;
            int D3 = (D / 100) % 10;
            int D4 = (D / 10) % 10;
            int D5 = D % 10;

            if (D1 == D5 && D2 == D4)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else
            {
                Console.WriteLine("Число не является палиндромом");
            }
}