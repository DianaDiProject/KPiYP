class Program
{
    static int[,] Input(int n) // Метод для ввода матрицы
    {
        int[,] matrix = new int[n, n]; // Создание матрицы размером n x n
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Введите элемент a[" + i + "," + +j + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        return matrix;
    }

    static void PrintMatrix(int[,] matrix, int n) // Метод для вывода матрицы
    {
        Console.WriteLine("Ваша матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + " "); 
            }
            Console.WriteLine(); 
        }
    }

    static int Perimeter(int[,] matrix, int n) // Метод для вычисления суммы положительных элементов по периметру матрицы
    {
        int sum = 0;

        // Суммируем элементы верхней строки
        for (int j = 0; j < n; j++)
        {
            if (matrix[0, j] > 0)
            {
                sum += matrix[0, j];
            }
        }

        // Суммируем элементы правого столбца (без первой и последней строки)
        for (int i = 1; i < n - 1; i++)
        {
            if (matrix[i, n - 1] > 0)
            {
                sum += matrix[i, n - 1];
            }
        }

        // Суммируем элементы левого столбца (без первой и последней строки)
        for (int i = 1; i < n - 1; i++)
        {
            if (matrix[i, 0] > 0)
            {
                sum += matrix[i, 0];
            }
        }

        // Суммируем элементы нижней строки
        for (int j = 0; j < n; j++)
        {
            if (matrix[n - 1, j] > 0)
            {
                sum += matrix[n - 1, j];
            }
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введите размерность матрицы n: ");
        int n = int.Parse(Console.ReadLine()); // Вводим размерность матрицы
        int[,] matrix = Input(n); // Вводим матрицу
        PrintMatrix(matrix, n); // Выводим матрицу
        Console.WriteLine("Сумма положительных элементов по периметру матрицы = " + Perimeter(matrix, n)); // Вывод результата
    }
}
