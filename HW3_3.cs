Console.Clear();
Console.WriteLine ("Таблица кубов");

Console.WriteLine ("Введите число");
int x = int.Parse(Console.ReadLine ()!);

int i = 1;
while (x >= i) 
{
    var result = Math.Pow (i, 3);
    i++;
    Console.WriteLine (result);
}