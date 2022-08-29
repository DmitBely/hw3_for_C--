// Найти кубы чисел от 1 до N

void FillArray(int[] col)
{   
    int i = 0;
    int sum = 0;
    while (i < col.Length)
    {
        sum = sum + 1;
        col[i] = sum;
        i++;
    }
}

void Cube(int[] col)
{
    for (int i = 0; i < col.Length; i++) col[i] = col[i] * col[i] * col[i];

}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.Write($"{col[i]} ");
    {
        
    }
}

Console.WriteLine("Введите число до которого нужно сосчитать кубы: ");
int limit = int.Parse(Console.ReadLine());
int[] arr = new int[limit];

FillArray(arr);
Cube(arr);
PrintArray(arr);
