using System.Diagnostics.CodeAnalysis;

class Program
{
    static int[] Input(int n) // Метод для ввода массива
    {
        int[] a = new int[n];
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write("Введите " + i + "-й элемент (a[" + i + "]): ");
            a[i] = int.Parse(Console.ReadLine());
        }
        return a; 
    }

    static void Print(int[] a)// Метод для вывода массива
    {
        foreach (int elem in a)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();
    }


    // Метод для нахождения максимального положительного нечетного элемента
    static int Maximum(int[] a)
    {
        int max = a[0]; //максимальное число - первое в массиве
        foreach (int num in a)
        {
            if (num > 0 && num % 2 != 0 && num > max) 
            {
                max = num;
            }
        }
        return max;
    }

    // Метод для нахождения минимального положительного четного элемента
    static int MinEven(int[] a)
    {
        int min = a[0]; //минимальное число - первое в массиве
        foreach (int num in a)
        {
            if (num > 0 && num % 2 == 0 && num < min) // Проверяем условия
            {
                min = num; // Обновляем минимальный четный элемент
            }
        }
        return min; // Если не найдено, возвращаем -1
    }

    // Метод для удаления совершенных чисел из массива
    static int[] RemovePerfectNumbers(int[] a, out int removedCount)
    {
        removedCount = 0; // Счетчик удаленных элементов
        int[] tempArray = new int[a.Length]; // Временный массив для хранения оставшихся элементов
        int index = 0;

        foreach (int num in a)
        {
            if (!IsPerfect(num)) // Если число не совершенное
            {
                tempArray[index++] = num; // Сохраняем его во временный массив
            }
            else
            {
                removedCount++; // Увеличиваем счетчик удаленных элементов
            }
        }

        Array.Resize(ref tempArray, index); // Уменьшаем размер временного массива до фактического количества элементов
        return tempArray; // Возвращаем массив без совершенных чисел
    }

    static bool IsPerfect(int num) // Метод для проверки, является ли число совершенным
    {
        
        if (num < 1) return false; // Совершенные числа только положительные
        /*
        int sum = 0;
        for (int i = 1; i <= num / 2; i++) // Проверяем делители до половины числа
        {
            if (num % i == 0)
            {
                sum += i; // Суммируем делители
            }
        }
        */
        if (num==1 && num==2 && num==7)
        {
            sum==num
        }
        return num; // Совершенное, если сумма делителей равна самому числу
    }

    static void Main()
    {
        Console.Write("Введите количество элементов массива n: ");
        int n = int.Parse(Console.ReadLine());
        int[] a = Input(n); // Вводим массив
        Console.WriteLine("Исходный массив:");
        Print(a); // Выводим исходный массив

        Console.WriteLine("Максимальный положительный нечетный элемент: " + Maximum(a));
        Console.WriteLine("Минимальный положительный четный элемент: " + MinEven(a));

        int removedCount;
        a = RemovePerfectNumbers(a, out removedCount); // Удаляем совершенные числа

        Console.WriteLine($"Количество удаленных совершенных чисел: {removedCount}");
        Console.WriteLine("Массив после удаления совершенных чисел:");
        Print(a); // Выводим измененный массив
    }
}
