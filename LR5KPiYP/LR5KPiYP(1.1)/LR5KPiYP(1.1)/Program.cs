class Program 
{
    static int[] Input() // Метод для ввода массива
    {
        Console.Write("Введите количество элементов в массиве (n): "); 
        int n = int.Parse(Console.ReadLine()); 
        int[] a = new int[n]; // Создание массива длиной n
        for (int i = 0; i < a.Length; i++) 
        {
            Console.Write("Введите " + i + "-й элемент (a[" + i + "]): "); 
            a[i] = int.Parse(Console.ReadLine()); 
        }
        return a;
    }

    static void Print(int[] a) // Метод для вывода массива на экран
    {
        foreach (int elem in a) 
        {
            Console.Write(elem + " "); 
        }
        Console.WriteLine(); 
    }

    static void Change(int[] a) // Метод для изменения элементов массива
    {
        for (int i = 0; i < a.Length; i++) 
        {
            if (a[i] < 0) 
            {
                a[i] *= 2; 
            }
        }
    }

    static void Main() // Главный метод программы
    {
        int[] a = Input(); // Вызов метода ввода
        Console.WriteLine("Исходный массив:"); 
        Print(a); // Вызов метода для вывода исходного массива

        Change(a); // Вызов метода изменения элементов массива
        Console.WriteLine("Измененный массив (отрицательные элементы умноженные на 2): "); 
        Print(a); // Вызов метода для вывода измененного массива
    }
}
