// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
int[] array = new int[8];

void Rand (int[] col)
{
    int i = 0;
    int length = col.Length;
    while(i<length)
    {
        col[i] = new Random().Next(10, 100);
        i++;
    }
}

void Write (int[] collection)
{
    int index = 0;
    int count = collection.Length;
    Console.Write("[");
    while(index<count-1) 
    {
        Console.Write($"{collection[index]}, ");
        index++;
    }
    Console.WriteLine($"{collection[count-1]}]");
}

Rand(array);
Write(array);