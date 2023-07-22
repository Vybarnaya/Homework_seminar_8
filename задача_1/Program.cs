// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2
Console.Clear();
Console.WriteLine("Введите кол-во строк m :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов n :  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int [,] array = CreateArray ( m,  n);
PrintArray( array);
Console.WriteLine();
CheangeArray(array);
PrintArray( array);


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

void  CheangeArray (int [,] array)
{
    int tmp =0;
    for (int i=0; i<m; i++){
        for (int j=0; j<n; j++)
        {
            for ( int h = 0; h< n-1; h++)
            if (array [i,h]< array [i,h+1])
            {
                tmp = array [i,h];
                array [i,h]=array [i,h+1];
                array [i,h+1] = tmp;
            }
        }
    }
}





