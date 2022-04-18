// Задача на вывод кубов целых чисел
Console.Write("Введите число:");
double number = Convert.ToDouble(Console.ReadLine());
double index = 1;

while (index <= number)
{
    double result = Math.Pow(index, 3);
    index +=1;
    Console.Write($"{result} ");
}