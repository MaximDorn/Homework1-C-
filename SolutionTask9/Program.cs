// Метод решения задачи Вариант 1
void variant1(System.Random numberSyntezator)
{
    int number = numberSyntezator.Next(10, 100);
    Console.WriteLine(number);



    int firstNumber = number / 10;
    int secondNumber = number % 10;

    if (firstNumber > secondNumber)
    {
        Console.WriteLine(firstNumber);
    }
    else
    {
        Console.WriteLine(secondNumber);
    }
}

// Метод решения задачи Вариант 2
void variant2()
{
    int number2 = new Random().Next(10, 100);
    Console.Write("The random number is: ");
    Console.WriteLine(number2);

    string stringNum = number2.ToString();
    Console.Write("The biggest digit is : ");

    if (stringNum[0] > stringNum[1])
    {
        Console.WriteLine(stringNum[0]);
    }
    else
    {
        Console.WriteLine(stringNum[1]);
    }
}

// Метод решения задачи Вариант 3
void variant3(System.Random numberSyntezator)
{
    char[] digits = numberSyntezator.Next(10, 100).ToString().ToCharArray();
    Console.WriteLine(digits);

    int firstNumber = ((int)digits[0]) - 48;
    int secondNumber = ((int)digits[1]) - 48;

    int resultNumber = firstNumber > secondNumber ? resultNumber = firstNumber : resultNumber = secondNumber;

    Console.WriteLine(resultNumber);
}

System.Random numberSyntezator = new Random();
variant1(numberSyntezator);
variant2();
variant3(numberSyntezator);