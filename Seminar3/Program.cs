/*void ShowDiapozone(int quad){

    if(quad == 1) Console.WriteLine("x > 0 and y > 0");
    else if(quad == 2) Console.WriteLine("x < 0 and y > 0");
    else if(quad == 3) Console.WriteLine("x < 0 and y < 0");
    else if(quad == 4) Console.WriteLine("x > 0 and y < 0");
    else Console.WriteLine("Uncorrect input!");
}

    Console.WriteLine("Input a number quardinat: ");
    int quardinat = Convert.ToInt32(Console.ReadLine());

ShowDiapozone(quardinat);*/

/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
и выдаёт номер четверти плоскости, в которой находится эта точка.*/

int NumberQuadrant(int x, int y){

    if(x > 0 && y > 0) return 1;
    if(x> 0 && y < 0) return 4;
    if(x> 0 && y < 0) return 2;
    if(x< 0 && y > 0) return 3;

    return -1;
}

Console.WriteLine("Input a X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input a Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int res = NumberQuadrant(x , y);

if ( res == -1 ) Console.WriteLine("Nit correect ");
else Console.WriteLine("quardinat " +res);


/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.* 4 аргумента */

double Distance(double xa, double xb, double ya, double yb)
{
    double firstLenght = xb - xa;
    double seconLenght = yb - ya;
}

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.*/