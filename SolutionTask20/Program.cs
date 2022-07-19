// Программа, которая принимает на вход
//координаты двух точек и находит расстояние между
// ними в 2D пространстве.

int coordXA;
int coordYA;
int coordXB;
int coordYB;
double lengthAB;

// Метод считывает координаты точек A и B
void readDataOfPoint()
{
    Console.WriteLine("Введите координату X точки A");
    coordXA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки A");
    coordYA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату X точки B");
    coordXB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYB = int.Parse(Console.ReadLine());
}

// Вычисляет расстояние между точками A и B
void calculateLengthAB()
{
    lengthAB = Math.Sqrt(Math.Pow((coordXA - coordXB), 2) + Math.Pow((coordYA - coordYB), 2));
}

readDataOfPoint();
calculateLengthAB();

Console.WriteLine(lengthAB);