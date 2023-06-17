Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[M];

void MassivArray(int M)
{
    for (int i = 0; i < M; i++)
    {
        Console.WriteLine($"Введите { i + 1} элемент массива: ");
        Array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
int CountNumbers (int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
            count ++;
    }
    return count;
}
Console.Clear();
MassivArray(M);
Console.Write($"Количество чисел больше нуля: {CountNumbers(Array)}");