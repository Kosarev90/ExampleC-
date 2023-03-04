/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int QualityNumber(int m){

    int result = 0;
    for(int i = 0; i < m; i ++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0)
            result ++;
    } 
return result;
}

Console.Write("Input in number: ");
int m = Convert.ToInt32(Console.ReadLine());
if(m < 0){
        Console.WriteLine("Input the number greater 0");
    }
    else
        Console.WriteLine($"The user entered {QualityNumber(m)} number greater than 0");*/


/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
 
int x = (b2 - b1) / (k1 - k2);
int y = k1 * x + b1;
 
Console.WriteLine("The point of intersection is ({0}, {1})", x, y);*/