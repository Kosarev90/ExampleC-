/*int cutNumber(int num)
{
    int hundres = num / 100;
    int units = num % 10;
    int result = hundres * 10 + units;

    return result;
}

int randNumber = new Random().Next(100 , 1000);
int newNumber = cutNumber(randNumber);

Console.WriteLine($"New version of {randNumber} is {newNumber}");*/

// task 2

/*bool isMultiptyed(int num, int div1, int div2){
    return num % div1 == 0 && num % div2 == 0;
}

Console.Write("Input a number for checking:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a first divider:");
int divider1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second divider:");
int divider2 = Convert.ToInt32(Console.ReadLine());

bool result = isMultiptyed(number, divider1, divider2);
Console.WriteLine($"Anser: {result}");*/

/*Task 3 напишите программу которая выводит случайное число на отрезке 10 до 99 и показывает наибольшую цифру числа



int cutNumber(int num){
    int dec = num / 10;
    int unit = num % 10;
    int result = 0;
    if (dec >  unit)
        result = dec;
    else result = unit;
    return result;
}
int randomNumber = new Random().Next(10 , 100);
Console.WriteLine("Input a number:" + randomNumber);
int anserNumber = cutNumber(randomNumber);
Console.Write("Anser: " + anserNumber);*/

// напишите программу которая принимает два числа на вход и проверяет является ли число квадратом другого



