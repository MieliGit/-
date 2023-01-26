//Нахождение дня недели по числу 
Console.Clear();
Console.WriteLine("Введите число от 1 до 7");
int number = int.Parse(Console.ReadLine());
string dayofWeek = "Введено неверное число";
if(number == 1) 
{
    dayofWeek = "Понедельник";
}
else if (number == 2)
{
    dayofWeek = "Вторник";
}
else if (number == 3)
{
    dayofWeek = "Среда";
}
else if (number == 4)
{
    dayofWeek = "Четверг";
}
else if (number == 5)
{
    dayofWeek = "Пятница";
}
else if (number == 6)
{
    dayofWeek = "Суббота";
}
else if (number == 7)
{
    dayofWeek = "Воскресенье";
}
Console.WriteLine(dayofWeek);
