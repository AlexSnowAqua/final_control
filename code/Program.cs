using System;

class Program
{
    static void Main(string[] args)
    {
        // тот самый пользовательский ввод
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArray = Console.ReadLine().Split(' ');

        // подсчет количества мишеней
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // создание нового массива нужного размера
        string[] newArray = new string[count];

        // складываем мишени в новый массив
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        // вывод исходного массива
        Console.WriteLine("Исходный массив:");
        foreach (string str in inputArray)
        {
            Console.Write(str + " ");
        }

        // вывод мишеней
        Console.WriteLine("\nНовый массив из строк, длина которых меньше или равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.Write(str + " ");
        }
    }
}

// готово :)