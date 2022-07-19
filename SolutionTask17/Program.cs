// Программа, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой
// находится эта точка.

// Метод считывает точки и возвращает массив с ними
int[,] readPoint()
{
    string inputLine = Console.ReadLine();

    // x=34; y=-30 -> 4

    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";")); // Выделение от 0 до ;, то есть "X=34"
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1); // Выделить непосредственно "34"

    string coordYline = inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYline = coordYline.Substring(coordYline.IndexOf("=") + 1);

    // Console.Write(coordX + " " + coordY);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYline);

    int[,] arrayOut = new int[1, 2];

    arrayOut[0, 0] = coordX;
    arrayOut[0, 1] = coordY;

    return arrayOut;
}

// Печатает номер четверти
void printQuater(int[,] arrayPoint)
{
    if(arrayPoint[0,0]>0 && arrayPoint[0,1]>0)
    Console.WriteLine("1 четверть");
    
    if(arrayPoint[0,0]<0 && arrayPoint[0,1]>0)
    Console.WriteLine("2 четверть");

    if(arrayPoint[0,0]<0 && arrayPoint[0,1]<0)
    Console.WriteLine("3 четверть");

    if(arrayPoint[0,0]>0 && arrayPoint[0,1]<0)
    Console.WriteLine("4 четверть");   
}

int[,] arrayPoint = readPoint();
printQuater(arrayPoint);