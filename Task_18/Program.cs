// Задача 30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
// Создать новый массив и сложить их 

Console.Clear();

int[] arr = new int[8];
int[] arr2 = new int[8];
int[] arr3 = new int[8];

RandomArray(arr);
PrintArray(arr);
Console.WriteLine("   ");
RandomArray(arr2);
PrintArray(arr2);
Console.WriteLine("   ");
SumArr(arr, arr2, arr3);
PrintArray(arr3);

void PrintArray(int[] array)
{
    for(int i = 0; i<8; i++)
    {
        Console.Write(array[i]+ " ");
    }
}
void RandomArray(int[] array)
{
    for(int i = 0; i<8; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

void SumArr(int[] array1, int[] array2, int[] array3)
{
    for(int i = 0; i<8; i++)
    {
        array3[i] = array2[i] + array1[i];
    }
}