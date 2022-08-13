int x = ReadInt("Введите координату X: ");
int y = ReadInt("Введите координату Y: ");

if(x == 0 || y == 0)
{
Console.WriteLine("Четверть определить невозможно");
return;
}

if (x > 0 && y > 0)
{
Console.WriteLine("Четверть 1");
}
else if(x < 0 && y > 0)
{
Console.WriteLine("Четверть 2");
}
else if(x < 0 && y < 0)
{
Console.WriteLine("Четверть 3");
}
else if(x > 0 && y < 0)
{
Console.WriteLine("Четверть 4");
}


int ReadInt(string message)
{
Console.Write(message);
return Convert.ToInt32(Console.ReadLine());
}
