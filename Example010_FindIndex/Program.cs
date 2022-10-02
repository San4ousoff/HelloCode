// Вывод первого индекса искомого числа в массиве
Console.Clear();

int[] array = {21, 43, 65, 43, 45, 34};
int length = array.Length;
int count = 0;

Console.Write("Введите искомое число: ");
int find = int.Parse(Console.ReadLine());

while (count < length)
{ 
    if (array[count] == find) 
    {
        Console.WriteLine(count);
        break;
    }    
count++;
}