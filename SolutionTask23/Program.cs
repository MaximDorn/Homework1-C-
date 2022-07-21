// Программа, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN); // Парсим введённое число в int

    // Вводим необходимые переменные
    int lineN = 0;
    int lineNNN = 0;

    int s = 1;

    // Cоздаём шапку для таблицы 
    Console.WriteLine(new string('-', 27));
    Console.WriteLine("|{0,-12}|{1,-12}|", "Число", "Куб");
    Console.WriteLine(new string('-', 27));

    // Каждый цикл будет прописывать 2 значения: число и число возведённое в куб.
    while (s <= numberN)
    {
        lineN = s; // Числа без возведения в степень
        Console.Write("| {0, -10} | ", lineN);

        lineNNN = s * s * s; // Возводим числа в куб
        Console.Write("{0, -10} | ", lineNNN);

        s++;

        Console.WriteLine(); // Начать с новой строки
        Console.WriteLine(new string('-', 27)); // Прорисовать линию и начать с новой строки
    }
}