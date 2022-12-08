void Print(int[,] arr)
{
    int size = arr.GetLength(0);
    int size1 = arr.GetLength(1);

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size1; j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
    
}

int[,] MassNums(int s1,int s2, int from, int to)
{
    int[,] arr = new int[s1,s2];

    for (int i = 0; i < s1; i++)
    {
        for (int j = 0; j < s2; j++)
        {
        arr[i,j] = new Random().Next(from, to);
        }
    }
    return arr;
}

void Print1(int[,] arr)
{
    int size = arr.GetLength(0);
    int size1 = arr.GetLength(1);
    int[,] arr2 = new int[size,size1];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size1; j++)
        {   
            arr2[i,j] = arr[i,j];
            Console.Write($"{arr2[i,j]}* ");
        }
        Console.WriteLine();
    }
    
}

int[,] arr_1 = MassNums(int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()),
                       int.Parse(Console.ReadLine()));
Print(arr_1);
Print1(arr_1);