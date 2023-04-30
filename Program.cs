// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] arrayString = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2",
 "computer science", "Russia", "Denmark", "Kazan", "12", "123" };

Console.WriteLine("Исходный массив: ");
PrintArray(arrayString);
int numberOfSymbols = 3;
Console.WriteLine($"Результирующий массив строк с длинной не больше {numberOfSymbols} символов: ");
PrintArray(ArraySort(arrayString, numberOfSymbols));

// вывод массива строк
void PrintArray(string[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i < count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

// выборка строк с заданным минимальным количеством символов
string[] ArraySort(string[] array, int numberOfSymbols)
{
    // определяем число элементов в массиве подходящих по параметрам выборки
    int countOfElements = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numberOfSymbols)
        {
            countOfElements++;
        }
    }
    // создаем временный массив с ранее посчитанным числом элементов и заполняем его
    string[] tmpArray = new string[countOfElements];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= numberOfSymbols)
        {
            tmpArray[j] = array[i];
            j++;
        }
    }

    return tmpArray;
}
