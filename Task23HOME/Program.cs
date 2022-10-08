/*Задача 23
Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int GetNum(string message)
{
    int result = 0;
    bool isCorrect = false;
    while (!isCorrect)
    {
        Console.WriteLine(message);
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect)
            Console.WriteLine("Вы ввели не число, пожалуйста, введите число!");
        Console.WriteLine();
    }
    return result;
}

void GetNumberN(int number)
{
    Console.Write($"{number} ->");
    for (int i = 1; i <= number; i++)
    {
        double cube = Math.Pow(i, 3);
        Console.Write($"{cube}, ");
    }
}
int numb = GetNum("Введите, пожалуйста, число: ");
GetNumberN(numb);