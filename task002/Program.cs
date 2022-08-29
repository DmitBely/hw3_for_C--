// Возведите число А в натуральную степень B используя цикл

Console.Write("Введите число: ");
int A = int.Parse(Console.ReadLine());

Console.Write("В какую степень его нужно возвести?: ");
int B = int.Parse(Console.ReadLine());


void Magic(int number, int grade)
{   
    int res = number;
    for (int i = 0; i < grade; i++) res *= grade;
    Console.Write(res);

}

Magic(A, B);