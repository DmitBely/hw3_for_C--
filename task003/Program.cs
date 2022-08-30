// Подсчитать сумму цифр в числе

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

void SumDigit (int num)
{   
    int sum = 0;
    while (num % 10 > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    Console.WriteLine($"Сумма цифр числа = {sum} ");
}

SumDigit(number);