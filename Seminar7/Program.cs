Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

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

int[,] newArray = CreateRndom2dArray();
ShowArray2D(newArray);


/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i + j. Выведите полученный массив на экран.

Console.Write("Input a number of m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] CreateArray(int m, int n){

    int[,] array2d = new int[m, n];

    for(int i = 0; i < m; i ++){
        for(int j = 0; j < n; j ++){
            array2d[i, j] = i + j;
        }
    }
    return array2d;
}

void  ShowArray2D(int[,] array){

    for(int i = 0; i < array.GetLength(0); i++) {   
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray2D(CreateArray(m, n));
*/
/*адайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.*/

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


int[,] arrayEvenIndex(int [,] array){
    for(int i = 0; i < array.GetLength(0); i += 2){
        for(int j = 0; j < array.GetLength(1); j += 2){
            array[i, j] = array[i * i, j * j];
        }
    }
    return array;
}

int[,] array = CreateRndom2dArray();
ShowArray2D(array);
array = arrayEvenIndex(array);
ShowArray2D(array);

/*адайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.*/