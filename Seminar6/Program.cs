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
    }
    Console.WriteLine();
}

void ReverseArray (int[] array){

    for(int i = 0, j = array.Length - 1; i < j; i++, j--){

        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

}


Console.Write("Input a quality of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);

ShowArray(newArray);
ReverseArray(newArray);
ShowArray(newArray);*/

/*написать программу которая принимает на вход 3 числа и проверяет может ли существовать треугольник со сторонами такой длины

Console.Write("Input a number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c number: ");
int c = Convert.ToInt32(Console.ReadLine());

bool isTraingle(int a, int b, int c){

    if(a > b + c && b > a + c && c > a + b)
        return false; 
  return true;
}
Console.WriteLine(isTraingle(a, b, c));*/

/*не используя рекурсию  выывести первые N чисел фибоначи при том первые два числа А и B (0 01 1 2 3 5 8 13

Console.Write("Input a number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input c number: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] Fibonachi(int a, int b, int n){
int[] array = new int[n];
array[0] = a;
array[1]= b;
for(int i = 2; i < n; i ++){
    array[i] = array[i - 1] + array[i -2];
}
return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

ShowArray(Fibonachi(1, 2, 10));*/

/*Напишите программу которая будет созавать копию заданного массива с помощью поэлементного массива

int[]CopyArray(int[] array){

    int[] copyArray = new int [array.Length];

    for(int i = 0; i < array.Length; i ++){

        copyArray[i] = array[i];
    }

    return copyArray;
}*/

/*которая будет приобразовавывать в деситичное в двоичное*/


