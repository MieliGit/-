// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int size = Input("Введите размер массива");
int min = Input("Введите минимальное число в массиве");
int max = Input("Введите максималльное число в массиве");


int[] array = GetArray(size, min, max);

int n = Input("Введите число, наличие которого вам интересно");
if(CheckNumber(array, n)) Console.WriteLine("Есть"); else  Console.WriteLine("Нет");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res =new int[size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue+1);
        Console.Write($"{res[i]} ");
    } 
    Console.WriteLine();
    return res;
}

int Input(string message)
{
    Console.Write($"{message}: ");
    int res = int.Parse(Console.ReadLine());
    return res;
}

bool CheckNumber(int[] SomeArray,int Number)
{
    bool Check = false;
    for(int i = 0; i <= SomeArray.Length -1; i++) if(SomeArray[i] == Number) Check = true;
    return Check;
}
