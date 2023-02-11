/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter the first number: ");
int firstNumer = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNumer = Convert.ToInt32(Console.ReadLine());

if(firstNumer > secondNumer)
Console.WriteLine("The first number max");
else
Console.WriteLine("The second number max");
*/


/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the thrid number: ");
int thridNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (firstNumber > secondNumber)
max = firstNumber;
else max = secondNumber;

if(thridNumber > max)
max = thridNumber;

Console.WriteLine("Max number: " + max); */


/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
Console.WriteLine("This number is even");
else 
Console.WriteLine("This number is not even");*/


/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Enter the number: ");
int number = Convert.ToInt32(Console.ReadLine());
 int i = 1;
        while (i < number) {
            if (i % 2 == 0) {
                Console.Write(i + " ");
            }
            i++;
        }
*/




