/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    if((minValue < 1000 && minValue >= 100) && (maxValue < 1000 && maxValue > 100)){
        for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    }   
        else  Console.WriteLine("Not correct number!"); 
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int EvenNumbers(int[] array){

    int count = 0;
    for(int i = 0; i < array.Length; i++){
        if(array[i] %2 == 0 ){
            count ++;
        }
    }
    return count;
}

Console.Write("Input a quality of elements in array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());


ShowArray(CreateRandomArray(size, min, max));
int result = EvenNumbers(CreateRandomArray(size, min, max));
Console.Write($"Even {result} numbers in the array");*/

/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях

Console.Write("Input a quality of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}

int SumEvenNumber(int [] array){

    int sum = 0;
    for(int i = 0; i < array.Length; i+=2)
        sum = sum + array[i];
    
    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

ShowArray(CreateRandomArray(size, min, max));
int result = SumEvenNumber(CreateRandomArray(size, min, max));
Console.WriteLine(result);*/

/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] array = {2.3, 4.2, -3.2, 1.65, -2.43, 8.2, -5.3};

double maxValue(double[] array){

    double max = 0;

    for(int i = 0; i < array.Length; i++){
        if(max < array[i])
        max = array[i];
    }
    return max;
}

double minValue(double[] array){

    double min = 0;

    for(int i = 0; i < array.Length; i++){
        if(min > array[i])
        min = array[i];
    }
    return min;
}

void PrintArray(double[] array){
 for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(array);
double maxVal = maxValue(array);
double minVal = minValue(array);
Console.WriteLine($"Maximum value {maxVal}");
Console.WriteLine($"Minimum value {minVal}");
double difference = maxVal - minVal;
Console.WriteLine($"Difference value between maximum and minimum value = {difference}");*/