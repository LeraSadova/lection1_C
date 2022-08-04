//задача с треугольником
Console.Clear(); //очистка экрана при запуске
//Console.SetCursorPosition(10,4);  // указываем отступ от левого края и отступ  от правого края
//Console.WriteLine("+");

//определяем вершины треугольника
int xa=15, ya=1,
    xb=1, yb=10,
    xc=30, yc=10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x=xa, y=ya;

int count=0;

while (count<10000)
{
    int what= new Random().Next(0,3); //what - переменная. и выдаваться значение 0, 1, 2
    //т.е. определили случайное число
    if (what==0)
    {
        x=(x+xa)/2; //положили половинку отрезка
        y=(y+ya)/2;
    }
    if (what==1)
    {
        x=(x+xb)/2;
        y=(y+yb)/2;
    }
    if (what==2)
    {
        x=(x+xc)/2;
        y=(y+yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count=count+1;
}
Console.SetCursorPosition(0, yc+1);

