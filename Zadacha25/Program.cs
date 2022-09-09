// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
Console.WriteLine("Введите два числа через энтер");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

int Degree (int c, int d)
{
    int i = 1;
    int fin = c;
    while(i<d)
    {
        fin = fin*c;
        i++;
    }
    return fin;
}

Console.WriteLine($"{a}, {b} -> {Degree (a, b)} ");