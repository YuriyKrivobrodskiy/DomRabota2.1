int [] array = new int[8];
int[] FillArray()
{
    int Length = array.Length;
    int index = 0;
    while (index < Length)
    {
        array[index] = new Random().Next(0, 99);
        index++;
    }
    return array;
}

System.Console.WriteLine(string.Join(" ", FillArray()));