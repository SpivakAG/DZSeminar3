// Программа для нахождения длины отрезка между 2 точками в 3D
double ax = Coordinate("x", "A");
double ay = Coordinate("y", "A");
double az = Coordinate("z", "A");
double bx = Coordinate("x", "B");
double by = Coordinate("y", "B");
double bz = Coordinate("z", "A");

double squareX = Math.Pow(bx-ax, 2);
double squareY = Math.Pow(by-ay, 2);
double squareZ = Math.Pow(bz-az, 2);
double sqrt = Math.Sqrt(squareX+squareY+squareZ);

Console.Write(sqrt);

double Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}:");
    return Convert.ToDouble(Console.ReadLine());
}