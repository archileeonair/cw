// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void CountArray(string[] array, int j)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j++;
        }
    }
    string[] array2 = new string[j];
    j = 0;
    for (int i = 0; i <= array2.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    Console.WriteLine(String.Join(", ", array2));
}

Console.Clear();
int j = 0;
string[] array = {"computer science", "123"};
CountArray(array, j);