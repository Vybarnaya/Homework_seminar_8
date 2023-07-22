// 60. *Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)*/

int[,,] arr = GetArr();
PrintArray(arr);
int[,,] GetArr(){
    int[,,] array = new int[2,2,2];
    for(int i = 0;i < 2;i++){
        for(int j = 0;j < 2;j++){
            for(int l = 0;l < 2;l++){
                array[i,j,l] = new Random().Next(10,100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] arr){
    for(int i = 0;i < 2;i++){
        for(int j = 0;j < 2;j++){
            for(int l = 0;l < 2;l++){
                Console.Write(arr[i,j,l]);
                Console.WriteLine($"({i},{j},{l})");           
            }
        }
    }
}