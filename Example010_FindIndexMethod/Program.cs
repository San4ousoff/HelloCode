// Вывод первого индекса искомого числа в массиве с применением функции (метода) для его заполнения
Console.Clear();

void FillArray(int[] collection) // метод заполнения массива случайными числами
{
    int count = 0;
    int length = collection.Length;
    while (count < length)
    {
        collection[count] = new Random().Next(1,10);
        count++;
    } 
}

void PrintArray(int[] col) // метод вывода в консоль массива
{
    int count = 0;
    int length = col.Length;
    while (count < length)
    {
        Console.WriteLine(col[count]);
        count++;
    } 
}

int IndexOf (int[] collection) // метод поиска первого индекса искомого числа
{
    int count = 0;
    int position = -1; // терминал покажет -1, если искомого значения вообще не будет в массиве
    int length = collection.Length;
    
    Console.Write("Введите искомое число: ");
    int find = int.Parse(Console.ReadLine());
    
    while (count < length)
    { 
        if (collection[count] == find) 
        {
            position = count;
            Console.WriteLine("Индекс первого искомого числа в массиве: " + position);
            break;
        }    
        count++;
    }
    if (position == -1) Console.WriteLine("Искомого числа нет в массиве!");
    return(position);
}

int[] array = new int [10];
FillArray(array);
PrintArray(array);
IndexOf(array);