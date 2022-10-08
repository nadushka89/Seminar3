/* Задача 19
Напишите программу, которая принимает на вход
пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

void GetPolindroid(int number)
{
    if (number < 100000 && number > 9999)
    {
        string numberAsString = number.ToString();
        if (int.Parse(numberAsString[0].ToString()) == int.Parse(numberAsString[4].ToString()) &&
         int.Parse(numberAsString[1].ToString()) == int.Parse(numberAsString[3].ToString()))
        {
            Console.WriteLine($"{number} является полиндромом");
        }
        else
            Console.WriteLine($"{number} не является полиндромом");
    }
    else
        Console.WriteLine($"{number} не является пятизначным числом");
}
GetPolindroid(234);