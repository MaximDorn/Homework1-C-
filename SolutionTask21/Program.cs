// Программа, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

// Ввод глобальных переменных в рамках задачи
int coordXA;
int coordYA;
int coordZA;
int coordXB;
int coordYB;
int coordZB;
double lengthAB;

// Метод считывает координаты точек A и B
void readDataOfPoint()
{
    // Ввод координат XYZ для точки "A"
    Console.WriteLine("Введите координату X точки A");
    coordXA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки A");
    coordYA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки A");
    coordZA = int.Parse(Console.ReadLine());

    // Ввод координат XYZ для точки "B"
    Console.WriteLine("Введите координату X точки B");
    coordXB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Y точки B");
    coordYB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите координату Z точки B");
    coordZB = int.Parse(Console.ReadLine());
}

// Метод вычисляет расстояние между точками A и B в трёхмерном пространстве
void calculateLengthAB()
{
    lengthAB = Math.Sqrt(
               Math.Pow((coordXA - coordXB), 2) +
               Math.Pow((coordYA - coordYB), 2) + 
               Math.Pow((coordZA - coordZB), 2));
}

readDataOfPoint();
calculateLengthAB();

Console.WriteLine("Длина отрезка AB = " + lengthAB);