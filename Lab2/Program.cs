using System; 

public class Program
{

    public static double[] ReplaceLessThanK(double[] arr, double k)
{
    double[] result = new double[arr.Length];

    for (int i = 0; i < arr.Length; i++)
        result[i] = arr[i] < k ? k : arr[i];

    return result;
}

public static int[] MinElementIndexes(double[] arr)
{
    double min = arr[0];

    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < min)
            min = arr[i];

    List<int> indexes = new List<int>();

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] == min)
            indexes.Add(i);

    return indexes.ToArray();
}

public static int[,] SwapRowsMatrix(int[,] a)
{
    int n = a.GetLength(0); // рядки
    int m = a.GetLength(1); // стовпці

    int[,] result = (int[,])a.Clone();

    if (n % 2 == 0)
    {
        int r1 = n / 2 - 1;
        int r2 = n / 2;

        for (int j = 0; j < m; j++)
        {
            int temp = result[r1, j];
            result[r1, j] = result[r2, j];
            result[r2, j] = temp;
        }
    }
    else
    {
        int mid = n / 2;

        for (int j = 0; j < m; j++)
        {
            int temp = result[0, j];
            result[0, j] = result[mid, j];
            result[mid, j] = temp;
        }
    }

    return result;
}

public static int[] FirstPositivePerColumn(int[][] arr)
{
    int maxCols = arr.Max(r => r.Length);
    int[] result = new int[maxCols];

    for (int j = 0; j < maxCols; j++)
    {
        result[j] = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (j < arr[i].Length && arr[i][j] > 0)
            {
                result[j] = arr[i][j];
                break;
            }
        }
    }

    return result;
}
    static int ReadInt(string msg)
    {
        while (true)
        {
            Console.Write(msg);
            if (int.TryParse(Console.ReadLine(), out int x))
                return x;
            Console.WriteLine("Помилка!");
        }
    }

    static double ReadDouble(string msg)
    {
        while (true)
        {
            Console.Write(msg);
            if (double.TryParse(Console.ReadLine(), out double x))
                return x;
            Console.WriteLine("Помилка!");
        }
    }

    static void Task1()
    {
        int n = ReadInt("Розмір масиву: ");
        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
            arr[i] = ReadDouble($"arr[{i}] = ");

        double k = ReadDouble("Введіть число: ");

        for (int i = 0; i < n; i++)
            if (arr[i] < k)
                arr[i] = k;

        Console.WriteLine("Результат:");
        foreach (var x in arr)
            Console.Write(x + " ");
        Console.WriteLine();
    }

    static void Task2()
    {
        int n = ReadInt("Кількість елементів: ");
        double[] arr = new double[n];

        for (int i = 0; i < n; i++)
            arr[i] = ReadDouble($"a[{i}] = ");

        double min = arr[0];
        for (int i = 1; i < n; i++)
            if (arr[i] < min)
                min = arr[i];

        Console.WriteLine("Мінімальні елементи на позиціях:");
        for (int i = 0; i < n; i++)
            if (arr[i] == min)
                Console.Write(i + " ");
        Console.WriteLine();
    }

    static void Task3()
    {
        int n = ReadInt("Розмір матриці n: ");
        int[,] a = new int[n, n];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < n; j++)
                a[i, j] = ReadInt($"a[{i},{j}] = ");

        if (n % 2 == 0)
        {
            int r1 = n / 2 - 1;
            int r2 = n / 2;

            for (int j = 0; j < n; j++)
            {
                int temp = a[r1, j];
                a[r1, j] = a[r2, j];
                a[r2, j] = temp;
            }
        }
        else
        {
            int mid = n / 2;

            for (int j = 0; j < n; j++)
            {
                int temp = a[0, j];
                a[0, j] = a[mid, j];
                a[mid, j] = temp;
            }
        }

        Console.WriteLine("Результат:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write(a[i, j] + "\t");
            Console.WriteLine();
        }
    }

    static void Task4()
    {
        int n = ReadInt("Кількість рядків: ");
        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            int m = ReadInt($"Кількість елементів у рядку {i}: ");
            arr[i] = new int[m];

            for (int j = 0; j < m; j++)
                arr[i][j] = ReadInt($"arr[{i}][{j}] = ");
        }

        int maxCols = 0;
        for (int i = 0; i < n; i++)
            if (arr[i].Length > maxCols)
                maxCols = arr[i].Length;

        int[] result = new int[maxCols];

        for (int j = 0; j < maxCols; j++)
        {
            result[j] = 0; 

            for (int i = 0; i < n; i++)
            {
                if (j < arr[i].Length && arr[i][j] > 0)
                {
                    result[j] = arr[i][j];
                    break;
                }
            }
        }

        Console.WriteLine("Результат:");
        for (int i = 0; i < result.Length; i++)
            Console.Write(result[i] + " ");
        Console.WriteLine();
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1 - Завдання 1");
            Console.WriteLine("2 - Завдання 2");
            Console.WriteLine("3 - Завдання 3");
            Console.WriteLine("4 - Завдання 4");
            Console.WriteLine("0 - Вихід");

            int choice = ReadInt("Ваш вибір: ");

            switch (choice)
            {
                case 1: Task1(); break;
                case 2: Task2(); break;
                case 3: Task3(); break;
                case 4: Task4(); break;
                case 0: return;
                default: Console.WriteLine("Невірний вибір"); break;
            }
        }
    }
}