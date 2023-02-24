 /*Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int reversNumber(int num){

    int rev_num = 0;
    while(num > 0){
        rev_num = rev_num * 10 + num % 10;
        num = num / 10;
    }
    return rev_num;
}

bool isPalindrom(int n){
    
    int rev_n = reversNumber(n);
if (rev_n == n)
            return true;
        else
            return false;
    
}

if(isPalindrom(num)== true){
    Console.WriteLine("This is number palindrom");
}
else 
    Console.WriteLine("This is number NOT palindrom");*/

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Input coordinate the first point x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate  the second point y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate  the thrid point z1:");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input coordinate the first point x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate  the second point y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input coordinate  the thrid point z2:");
int z2 = Convert.ToInt32(Console.ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double len = Math.Sqrt(A * A + B * B + C * C);
double Length = Math.Round(len, 2);

Console.WriteLine("Length of the segment in 3d coordinates:" + Length);*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Input is number: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;
while(i <= n){
    Console.Write(Math.Pow(i , 3) + " ");
    i++;
}*/