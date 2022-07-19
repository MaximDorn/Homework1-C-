// Программа, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

string? inputLineN = Console.ReadLine();

if (inputLineN != null)
{
    int numberN = int.Parse(inputLineN); // Парсим введённое число в int

    // Вводим необходимые переменные
    string lineN = string.Empty;
    string lineNNN = string.Empty;
    int s = 1; 
    
    while (s <= numberN)
    {
        lineN = lineN + s + " ";
        lineNNN = lineNNN + s * s * s + " "; // LineNNN будет накапливать кубы
        s++;
    }
    Console.WriteLine(lineN);
    Console.WriteLine(lineNNN);
}