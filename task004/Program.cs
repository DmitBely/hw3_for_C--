// Написать программу вычисления произведения чисел от 1 до N

int[] NewArray(int num)
{
    int[] arr = new int[num];
    int sum = 1;
    int i = 0;

    while (i < arr.Length) 
    {
        arr[i] = sum;
        sum = sum + 1;
        i++;
    }
    return arr;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
}

Console.WriteLine("Введите число до которого нужно посчитать произведения: ");
int number = int.Parse(Console.ReadLine());

void Multiply(int[] arr)
{   
    int multiply = 1;
    for (int i = 0; i < arr.Length; i++) multiply *= arr[i];
    Console.Write($"Произведение чисел от 1 до {number} = {multiply}");
}


int [] arrayValues = NewArray(number);
// PrintArray(arrayValues);
Multiply(arrayValues);