// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 
// 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.Clear();
int n = new Random().Next(7, 1000);
int a = 7;
int b = 23;

if(n%7 == 0 && n%23 == 0) Console.WriteLine($"{n} -> Yes"); 
else Console.WriteLine($"{n} -> No");


