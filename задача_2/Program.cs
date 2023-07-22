// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
Console.Write("Введите кол-во строк m :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов n :  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = CreateArray ( m,  n);
PrintArray( array);
Console.WriteLine();
GetArrayNums (CreateArray ( m,  n));
Console.WriteLine();
int st = GetArrayNums (array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {st} ");


int [,] CreateArray (int m, int n)
{
    int [,] array = new int [m,n];
    for ( int i =0; i < m; i++){
        for ( int j = 0; j < n; j++)
        {
            array [i,j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for ( int i =0; i< array.GetLength(0); i++){
        for ( int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array [i,j] + "  ");
        }
        Console.WriteLine();
    }
}

int  GetArrayNums ( int [,] array)
{
    int [] arr = new int [array.GetLength(0)];
    for (int i=0; i<array.GetLength(0); i++)
    {
        int sum =0;
        for (int j =0; j< array.GetLength(1); j++){
        
            sum = sum + array [i,j];
            arr [i]=sum;
        }
    }   
    
    int sumMin = arr[0];   
    int st = 0;
    for (int i=0; i<array.GetLength(0); i++)
    {
        if( arr [i] < sumMin )
        {
            sumMin = arr [i];
            st = i;
        }
    }
    return st;
}

