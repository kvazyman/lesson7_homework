// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

int[] array = {1, 2, 5, 0, 10, 34};

static void ArrayReverse(int[] array, int index)
{
    if (index >= 0)
        {
            Console.Write(array[index] + " ");
            ArrayReverse(array, index - 1);
        }
}

int index = array.Length-1;

ArrayReverse(array, index);
