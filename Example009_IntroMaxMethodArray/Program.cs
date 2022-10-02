// Поиск максимального числа в заданных 9ти числах с помощью функции (метода) с применением массива
Console.Clear();

// Функция, которая находит максимальное число из 3х 
int Max (int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int[] array ={111, 142, 183, 154, 145, 116, 167, 138, 159};

int max = Max (
    Max (array[0], array[1], array[2]), 
    Max (array[3], array[4], array[5]), 
    Max (array[6], array[7], array[8]));

Console.WriteLine(max);