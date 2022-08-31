// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];

void FillArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) col[i] = new Random().Next(0,10);
    Console.WriteLine(" ");
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.Write($"{col[i]} ");
}

void Positives(int[] col)
{   
    int i = 0;
    int positiveNums = 0;
    int negativeNums = 0;
    while (i < col.Length)
    {   
        if (col[i] >= 0)
        {
            positiveNums = positiveNums + col[i];
            i++;
        }
        else if (col[i] <= -1)
        {
            negativeNums = negativeNums + col[i];
            i++;
        }

    }
    Console.WriteLine($"Сумма положительных элементов массива: {positiveNums}");
    Console.WriteLine($"Сумма отрицательных элементов массива: {negativeNums}");
}




FillArray(array);
PrintArray(array);
Positives(array);
