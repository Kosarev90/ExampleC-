/* напишите программу которая принимает на вход число и выдает колчество цифр в числе

int Digits (int num){
    
    int result = 0;

    if(num== 0) result = 1;

    while(num != 0){
        num /= 10;
        result ++;
    }
    return result;
}

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = Digits(num);
Console.WriteLine($"This is number {num} digits in {res}");*/

/*Напишите программу которая принимает число N и выдает прозведение чисел от 1 до N

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int Multiplication(int n){
    
    int result = 1;

    for(int i = 1; i <= n; i++){
        result = result * i;
    }
    
    return result;
}

int r = Multiplication(n);
Console.WriteLine(r);*/

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
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
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);