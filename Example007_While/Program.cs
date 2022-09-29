// "Рисование треугольника и заполнение его серединами отрезков от рендомных точек
Console.Clear();
//Console.SetCursorPosition(10, 10);
//Console.WriteLine("+");
int xa = 30, ya = 0,
    xb = 0, yb = 15,
    xc = 60, yc = 15;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya; // Определение позиции первой точки

int count = 0;

while (count<100000)
{
    int what = new Random().Next(0,3); //Случайный выбор вершин треугольника [0, 1, 2]
    if (what == 0) 
    {
        x=(x+xa)/2;
        y=(y+ya)/2;
    }
    if (what == 1) 
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if (what == 2) 
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}