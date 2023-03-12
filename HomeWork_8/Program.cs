/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива


int[,] CreateRndom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colons: ");
int colons = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colons];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < colons; j++)
                array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void  ShowArray2D(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Decreasing(int[,] array){

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k  = j + 1; k  < array.GetLength(1); k ++){
                if(array[i, j] < array[i, k ]){
                        int temp= array[i, j];
                        array[i, j] = array[i,k];
                        array[i, k] = temp;
                }
            }
}

int[,] array = CreateRndom2dArray();
ShowArray2D(array);
Decreasing(array);
ShowArray2D(array);
*/


/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateRndom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colons: ");
int colons = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colons];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < colons; j++)
                array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void  ShowArray2D(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumString(int[,] array){

    int minSum = int.MaxValue;
    int minRow  = 0;

    if(array.GetLength(0) == array.GetLength(1)){

        for(int i = 0; i < array.GetLength(0); i++){
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++){
                rowSum += array[i, j];
            }

            if(rowSum < minSum){
                minSum = rowSum;
                minRow = i;
            }
        }
}
return minRow + 1;
}

int[,] array = CreateRndom2dArray();
ShowArray2D(array);
 int result = SumString(array);
 Console.WriteLine(result + " string in array contains minimum elements.");
*/


/*Задача 58: Задайте две матрицы. Дописать  программу, которая будет находить произведение двух матриц.

int[,] CreateRndom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colons: ");
int colons = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colons];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < colons; j++)
                array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void  ShowArray2D(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationArray(int[,] matrix1, int[,] matrix2 ){

    int[,] multiArray = new int[matrix1.GetLength(0),matrix2 .GetLength(1)];

    if(matrix1.GetLength(1) != matrix2 .GetLength(0)){
        Console.WriteLine("The number of columns in 1 matrix should contains with the number of lines 2 matrix");
    }
    else {
        for(int i = 0; i < matrix1.GetLength(0); i++){
            for(int j = 0; j < matrix2.GetLength(1); j++){
                int sum = 0;

                for(int k = 0; k < matrix1.GetLength(1); k++){
                    sum =+ matrix1[i, k] * matrix2[k, j];
                    multiArray[i, j] = sum;
                }
            }
        }
    }
   return multiArray;
}

int[,] array = CreateRndom2dArray();
ShowArray2D(array);
int[,] array2 = CreateRndom2dArray();
ShowArray2D(array2);
int[,] multiArray = MultiplicationArray(array, array2);
ShowArray2D(multiArray);
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Дописать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3DArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colons: ");
int colons = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of depth: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,,] array = new int[rows, colons, depth];

    int num = 10;
    int size = array.GetLength(0) * array.GetLength(1) * array.GetLength(2);

   if(size < 100){
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < colons; j++)
                for(int k = 0; k < depth; k++){
                    array[i,j,k] = num++;
                }
   }
   else Console.WriteLine("Array size greater than two digit number");   
return array;
}

void  ShowArray3D(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)
            Console.Write(array[i, j, k] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowIndex(int[,,] array){


   for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++){
                int n =+ array[i,j,k];
                Console.WriteLine($"{n}({i},{j},{k})");
                }
             
}

int[,,] array = CreateRandom3DArray();
ShowArray3D(array);
ShowIndex(array);
*/


/*Задача 62. измини программу, которая заполнит спирально массив rows на colons.
Например, на выходе получается вот такой массив:
*/

