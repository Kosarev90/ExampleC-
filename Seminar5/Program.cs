/*int[] CreateRandomArray(int size, int minValue, int maxValue)

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

int GetNegativeSum (int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if (array[i] < 0) 
            sum = sum + array[i];
    
    return sum;
}


Console.Write("Input a quality of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
int result = GetNegativeSum(newArray);
Console.WriteLine("Sum negativ is result: " + result);*/

/*написать программу по заммене элементов массива с + на - и наооборот

int[] ChangePosAndNeg(int[] array){


     for(int i = 0; i < array.Length; i++){
        array[i] *= -1;
     }
     return array;
}


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
}
}

int[] newArray = CreateRandomArray(12, -9, 9);
ShowArray(newArray);
ShowArray(ChangePosAndNeg(newArray));
*/

/*задайте массив. напишите програму корорая определяет прутствует ли заданное число или нет

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    
    return array;
}

bool FindNumber(int number, int[] array){

    for(int i = 0; i < array.Length; i++)
        if(array[i] == number) return true;

    return false;

}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}}

int number = Convert.ToInt32(Console.ReadLine());

FindNumber(number , CreateRandomArray(4, 3, 8));
*/


/*задайте массив из m случайных чисел. найти количество элеменотв в отрезке [a, b];*/

int[] ChangeRandomArray(int m, int maxValue, int minValue){

    int[] array = new int[m];

    for (int i = 0; i < m; i++){
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

