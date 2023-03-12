/*Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

void ShowNumbers(int n){
    Console.Write(n + " ");
    if(n > 1) ShowNumbers(n - 1);
    
}
ShowNumbers(n);
*/

/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Input the number m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number n: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumber(int m, int n){
if(m == n)
    return m;
else if(m > n){
        return m + SumNumber(m + 1, n);
    }
else{
        return n + SumNumber(m, n - 1);
    }
}

 int sum = SumNumber(M, N);
 Console.WriteLine($"The amount M and N = {sum}");
*/
/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
*/

Console.Write("Input the number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number n: ");
int n = Convert.ToInt32(Console.ReadLine());

int AkkermanNumber(int m, int n){

    if(m == 0) return n + 1;
    else if(n == 0) return AkkermanNumber(m - 1, 1);
    else return AkkermanNumber(m -1 , AkkermanNumber(m, n -1));
}

int result = AkkermanNumber(m, n);
Console.WriteLine(result);

