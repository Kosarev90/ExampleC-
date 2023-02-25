/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Input a number: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a degree: ");
int B = Convert.ToInt32(Console.ReadLine());

int Todegree(int a, int b){

    if(b == 0) a = 1;

    int result = 1;

    for(int i = 1; i <= b; i ++)
        result = result * a;

return result;
}

int anser = Todegree(A, B);

Console.WriteLine($"Degree {B} of number {A} equal to {anser}");*/


/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumber(int n){

    int result = 0;

    while(n > 0){
        result = result + n % 10;
        n /= 10;
    }
    return result;
}

int sum = SumNumber(number);
Console.WriteLine($"Summa from is number {number} equal to {sum}");*/


/*Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

int[] CreateRandomArray(int m, int minValue, int maxValue)
{
    int[] array = new int[m];

    for(int i = 0; i < m; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}}


Console.Write("Input a quality of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(m, min, max);
ShowArray(newArray);
*/