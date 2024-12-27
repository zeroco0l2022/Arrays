// See https://aka.ms/new-console-template for more information
class Arrays
{
    static void Main(string[] args)
    {
        /***Задача А*/

        /* 1 задание */

        // Объявляем массив
        var fibonacciNumbers = new int[8];

        // Заполняем через функцию
        FillFibonacciArray(fibonacciNumbers);

        // Вывод массива для проверки
        Console.WriteLine("Массив Фибоначчи:");
        foreach (var number in fibonacciNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

        /*** 2 задание*/

        // Объявляем массив
        var months = new string[12];
        FillMonthsArray(months);

        // Вывод массива для проверки
        Console.WriteLine("Массив месяцев:");
        foreach (var month in months)
        {
            Console.Write(month + " ");
        }
        Console.WriteLine();

        /*** 3 задание*/
        Console.WriteLine("Матрица:");
        var matrix = new int[3, 3];
        FillMatrix(matrix);

        // Вывод матрицы для проверки
        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        /*** 4 задание*/
        // Объявляем и заполняем массив
        var jaggedArray = new double[][]{
            [1, 2, 3, 4, 5],
            [Math.E, Math.PI],
            [Math.Log10(1), Math.Log10(10),  Math.Log10(100), Math.Log10(1000)]
        };

        // Вывод массива для проверки
        foreach (var row in jaggedArray)
        {
            foreach (var number in row)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        /***Задача Б*/

        int[] array = [1, 2, 3, 4, 5];
        int[] array2 = [7, 8, 9, 10, 11, 12, 13];

        /* 5 задание */

        // Копируем первые 3 элемента из array в array2
        Array.Copy(array, array2, 3);

        // Вывод результата для проверки
        Console.WriteLine("Измененный второй массив:");
        foreach (var number in array2)
        {
            Console.Write(number + " ");
        }

        /* 6 задание */

        // Увеличиваем размер массива в два раза
        Array.Resize(ref array, array.Length * 2);
        Console.WriteLine();

        // Вывод результата для проверки
        Console.WriteLine("Массив с увеличенным размером:");
        foreach (var number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();

    }

    private static void FillFibonacciArray(int[] array)
    {

        // Заполняем элементы массива
        for (var i = 0; i < array.Length; i++)
        {
            // Заполняем первые два элемента
            if (i < 2)
            {
                array[i] = i;

            }
            // Заполняем остальные
            else
            {
                array[i] = array[i - 1] + array[i - 2];
            }
        }
    }

    private static void FillMonthsArray(string[] months)
    {
        // Выставляем настройки языка на английский
        var translation = new System.Globalization.CultureInfo("en-US");
        for (var i = 0; i < 12; i++)
        {
            // Получаем название месяца
            var monthName = translation.DateTimeFormat.GetMonthName(i + 1);
            // Переводим первую букву названия месяца в верхний регистр
            months[i] = char.ToUpper(monthName[0]) + monthName[1..];
        }
    }


    private static void FillMatrix(int[,] matrix)
    {
        for (var row = 0; row < 3; row++)
        {
            for (var col = 0; col < 3; col++)
            {
                var number = col + 2;  // числа 2, 3, 4
                var pow = row + 1;   // степени 1, 2, 3
                matrix[row, col] = (int)Math.Pow(number, pow);
            }
        }
    }
}
