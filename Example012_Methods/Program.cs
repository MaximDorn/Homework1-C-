// Виды методов

// Методы, которые ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор...");
}
Method1();

// Методы, которые ничего не возвращают, но принимают аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Text message");

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "Method21", count: 3);

// Методы, которые что-то возвращают, но ничего не принимают
int Method3()
{
    return DateTime.Now.Year;
}
int yearResult = Method3();
Console.WriteLine(yearResult);

// Методы, которые что-то принимают и что-то возвращают
string Method4(int count, string text)
{
     int i = 0;
     string result = String.Empty;

     while (i < count)
     {
         result = result + text;
         i++;
     }
     return result;
 }
 string res = Method4(10, "asdfg");
 Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "asdfg");
// Console.WriteLine(res);

// // Цикл в цикле

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

// Задача: 
//Дан текст. В тексте нужно все пробелы заменить черточками,
//маленькие буквы “к” заменить большими “К”, а большие “С” заменить
//маленькими “с”:
string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             123456
// s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int length = text.Length;
//     for(int i=0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ','|');
// newText=Replace(text, 'к','К');
// Console.WriteLine(newText);

// Сортировка массива
int[] array = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }

}

PrintArray(array);
SelectionSort(array);

PrintArray(array);