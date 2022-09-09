//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int Summa (int b)
{
    int c = Math.Abs(b);
    int fin = c%10;
    while(c>1)
    {
        c = c/10;
        fin = (c%10)+fin;
    }

    return fin;
}

Console.WriteLine($"{a} -> {Summa(a)}");