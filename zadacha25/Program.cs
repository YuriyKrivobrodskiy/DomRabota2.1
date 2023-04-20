// задача 25: цикл, который принимает на вход два числа (А и В) и 
// возводит число А в натуральную степень В.
int Prpompt (string msg)
{
    System.Console.Write(msg);
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Produkt(int a, int b)
{
    int produkt = 1;
    for (int i = 0; i < b; i++)
    {
      produkt *= a;
    }
    return produkt;
}

bool CheckingB(int b)
{
    if (b < 0)
    {
        System.Console.WriteLine("Степень не  должна  быть меньше нуля!");
        return false;
    }
    return true;
}

int a = Prpompt("Введите число: ");
int b = Prpompt("Введите степень: ");
if (CheckingB(b))
{
    System.Console.WriteLine($"Число {a} в степени {b} равно {Produkt(a, b) }");
}
