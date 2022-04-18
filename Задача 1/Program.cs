// Программа для проверки является ли пятизначное число паллиндромом
Console.Write("Введите пятизначное число:");

int number = Convert.ToInt32(Console.ReadLine());
if (number <10000 || number > 99999) Console.Write("Введеное число не является пятизначным");

int reverse = ReverseNumber (number);

if (number != reverse) Console.Write("Число не является палиндромом");
else Console.Write("Число является палиндромом");


int ReverseNumber (int n1)
{
    int result = 0;
    while (n1 > 0)
    {
    result *= 10;
    result += n1 % 10;
    n1 /= 10;
    }
    return result;
}
