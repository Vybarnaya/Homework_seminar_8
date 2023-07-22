//   Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
Console.Clear();
Console.Write("Введите кол-во строк первой матрицы x :  ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов первой матрицы y :  ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во строк второй матрицы x1 :  ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов второй матрицы y1 :  ");
int y1 = Convert.ToInt32(Console.ReadLine());


int [,] array = CreateArray ( x,y,0,5);
PrintArray (array);
Console.WriteLine();
int [,] arr = CreateArray ( x1, y1,0,5);
PrintArray ( arr);
Console.WriteLine();

if (y != x1){
    Console.WriteLine("Умножать матрицы нельзя");
    return;
}

GetArrayResult (array,arr);
Console.WriteLine();
PrintArray ( GetArrayResult (array,arr));


int [,] CreateArray ( int m, int n,int minValue, int maxValue){
    int [,] mas = new int [m,n];
    for ( int i =0; i < m; i++){
        for ( int j =0; j < n; j++){
            mas [i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return mas;
}


void PrintArray( int [,]  mas1)
{
    for ( int i =0; i < mas1.GetLength(0); i++){
        for ( int j =0; j < mas1.GetLength(1); j++)
        {
            Console.Write( $" {mas1 [i,j]}  ");
        }
        Console.WriteLine();
    }
}

int [,] GetArrayResult (int [,] array, int [,] arr)
{
    int [,] result = new int [array.GetLength(0),arr.GetLength(1)];
    for (int i=0; i< array.GetLength(0); i++)
    {
        for ( int j =0; j< arr.GetLength(1);j++)
        {
            int sum =0;
            for ( int h =0; h< array.GetLength(1); h++)
            {
                sum =sum + array [i,h] * arr [h,j];
                result[i,j] = sum;
            }
        }
    }
    return result;
}
               
                
            
                

                    
                