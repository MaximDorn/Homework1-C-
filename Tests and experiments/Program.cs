var types = new[] 
{
    typeof(sbyte), 
    typeof(short),
    typeof(ushort),
    typeof(int),
    typeof(uint),
    typeof(long),
    typeof(ulong),
    typeof(float),
    typeof(double),
    typeof(decimal),
};


// Отступы каждых столбцов (10 первый, 20 второй, по 30 два последних) + 5 символов "|"
Console.WriteLine(new string('-', 10 + 20 + 30 + 30 + 5));
Console.WriteLine("|{0,10}|{1,20}|{2,30}|{3,30}|", "Type", "Byte(s) of memory", "Min", "Max");
Console.WriteLine(new string('-', 10 + 20 + 30 + 30 + 5));

foreach (var type in types)
{
    var size = Marshal.SizeOf(type);
    var min = type.GetField("MinValue").GetValue(null); // Берем нужное поле из типа
    var max = type.GetField("MaxValue").GetValue(null); // и забираем его значение

    Console.WriteLine("|{0,10}|{1,20}|{2,30}|{3,30}|", type.Name.ToLower(), size, min, max);
}