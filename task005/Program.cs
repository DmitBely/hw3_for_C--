// Показать кубы чисел, заканчивающихся на четную цифру

int[] NewArray(int num)
{
    int[] arr = new int[num];
    int i = 0;

    while (i < arr.Length) 
    {
        arr[i] = new Random().Next(1,51); 
        i++;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) Console.Write($"{arr[i]} ");
    Console.WriteLine(" ");
}

void EvensQubed(int[] col)
{
    int i = 0;
    while (i < col.Length)
    {
        if (col[i] % 2 == 0)
        {
            int cube = col[i] * col[i] * col[i];
            Console.WriteLine($"Куб числа {col[i]} = {cube}");
        }
        i++;
    }
}

Console.WriteLine("Введите количество цифр: ");
int number = int.Parse(Console.ReadLine());

int[] myArray = NewArray(number);
PrintArray(myArray);
EvensQubed(myArray);


