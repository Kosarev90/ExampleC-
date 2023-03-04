/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


 double[,] CreateRndom2dArray()
{
Console.Write("Input a number of m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of n: ");
int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                array[i, j] = new Random().Next(0 , 10) + Math.Round(new Random().NextDouble(), 2);

    return array;
}
void  ShowArray2D(double[,] array){

    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] array = CreateRndom2dArray();
ShowArray2D(array);
*/


/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int[,] array = CreateRndom2dArray();

 void SearthNumberInArray(int[,] array){

Console.Write("Searth element in array. Input a number of row: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colomn: ");
int col = Convert.ToInt32(Console.ReadLine());
int result = 0;
    if (row < 0 || row >= array.GetLength(0) || col < 0 || col >= array.GetLength(1))
        Console.WriteLine($"Element at positsion [{row}][{col}] not exist in array");
    else{
        result = array[row, col];
        Console.WriteLine($"Element at positsion [{row}][{col}] equals {result}");
    }
 }
 
 SearthNumberInArray(array);
 ShowArray2D(array);
*/


/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRndom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colons: ");
int colonms = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


    int[,] array = new int[rows, colonms];
        for(int i = 0; i < rows; i++)
            for(int j = 0; j < colonms; j++)
                array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

double[] AveregeNumbers(int[,] array){

    double[] colNumbers = new double[array.GetLength(1)];

for(int j = 0; j < array.GetLength(1); j++){
    int col = 0;
    for(int i = 0; i < array.GetLength(0); i++)
        col += array[i, j];

    colNumbers[j] = (double) col/array.GetLength(0);
}
return colNumbers;
}

void  ShowArray2D(int[,] array){

    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] newArray = CreateRndom2dArray();
double[] averegeArray = AveregeNumbers(newArray);
ShowArray2D(newArray);

Console.WriteLine("Average numbers for each column:");
for (int i = 0; i < averegeArray.Length; i++) {
    Console.Write(Math.Round(averegeArray[i], 2) + " ");
}
*/
