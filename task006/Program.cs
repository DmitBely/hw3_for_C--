// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран



int[] NewArray(int num)
{
    int[] arr = new int[num];
    int i = 0;

    while (i < arr.Length) 
    {
        arr[i] = new Random().Next(0,2); 
        i++;
    }
    return arr;
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++) Console.Write($"{col[i]} ");
    Console.WriteLine(" ");
}

int number = 8;
int[] arr = NewArray(number);
PrintArray(arr); 