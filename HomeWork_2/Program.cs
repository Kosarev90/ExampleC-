/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int threeDigitNumber(int num){
     int dec = num / 10;
    int unit = dec % 10;
    
    return unit;
} 

Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int amount = number.ToString().Length;

if(!(amount > 3 || amount < 3)){
int anserNumber = threeDigitNumber(number);
Console.WriteLine("Anser: " + anserNumber);
}
else Console.WriteLine("Input not correct number");*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Input any number: ");
int number = Convert.ToInt32(Console.ReadLine());

int thridDigit(int number, int count){
    int result = 0;
    while (count < 3){
        result = (number % 100) /  10;
        count ++;
    }
    return result;
}

int result = thridDigit(number, 3);
Console.WriteLine("Anser: " + result);

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("This is day off? Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isWeekand(int num){
    if (num == 6 || num == 7) return true;
return false;
}    

Console.WriteLine(isWeekand(number));*/
