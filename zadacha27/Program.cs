//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11;       82 -> 10;        9012 -> 12

int namber = ReadInt("число");
int sumElement = GetSumElement(namber);
System.Console.WriteLine(sumElement);

int ReadInt(string argument)
{
    System.Console.Write($"Введите {argument}: ");
    int num;
    while (! int.TryParse(System.Console.ReadLine(), out num))
    {
        System.Console.WriteLine("Это не число!");
    }
    return num;
}
int GetSumElement(int number)
{
    int sum = 0;
    int length = number.ToString().Length;
    for ( int i = 0; i < length; i++)
    {
        sum += number % 10;
       number = number / 10;
    }
    return sum;
}