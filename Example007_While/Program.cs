/*
int x0 = 40, y0 = 1;
int x1 = 1, y1 = 30;
int x2 = 80, y2 = 30;
*/

int x0 = 40 , y0 = 1;
int x1 = 1, y1 = 30;
int x2 = 80, y2 = 30;


Console.Clear();

Console.SetCursorPosition(x0, y0);
Console.Write("+");

Console.SetCursorPosition(x1, y1);
Console.Write("+");

Console.SetCursorPosition(x2, y2);
Console.Write("+");

int x = x0, y = y0;

int count = 0;
int maxCount = 10000;

while (count < maxCount)
{
    int i = new Random().Next(0, 3);
    if (i == 0)
    {
        x = (x + x0) / 2;
        y = (y + y0) / 2;
    }

    if (i == 1)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }

    if (i == 2)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }

    Console.SetCursorPosition(x,y);
    Console.Write("+");
    count++;
}