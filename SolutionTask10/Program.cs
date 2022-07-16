// Генерирование случайного трёхзначного числа на вход
int number = new Random().Next(100, 1000);
Console.Write("Number is: " + number);
Console.WriteLine(", Second digit is:");

// Solution 1: сначала деление без остатка на 10, затем остаток от деления на 10
int numberSecondDigit = (number / 10) % 10;
Console.WriteLine("- solution 1: " + numberSecondDigit);

// Solution 2: через перевод числа в строку
string numberAsString = number.ToString();
Console.WriteLine("- solution 2: " + numberAsString[1]);

// Solution 3: через преобразование числа в массив
int[] array = { number / 100, ((number / 10) % 10), number % 10 };
Console.WriteLine("- solution 3: " + array[1]);
