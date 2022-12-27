// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Задаем массив строки.

string[] arr =  {"Hello","am","is",
                     
                     "Once upon a time", 
                     "there was", "pop", 
                     "Tolokonny", "forehead",
                     "Went", "pop around", 
                     "the", "bazaar", "To see",
                     "some kind of product", 
                     "To see", "some", "kind of product",
                     "Towards", "him", "Balda", "Goes",
                     "without knowing where", 
                     "I have", "erected a monument", 
                     "to myself", "not", 
                     "made with hands" };



// Создаем метод вывода в консоль заданого массива

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
// Создаем метод вывода в консоль нового массива

void PrintArraySorting(string[] sortingArray)
{
    for (int i = 0; i < sortingArray.Length; i++)
    {
        Console.Write(sortingArray[i] + " ");
    }
}

