int friends = 2, count = 0, time = 0; //distance = 10000

Console.Write("Введите дистанцию: ");
int distance = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость первого друга: ");
int FFS = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость второго друга: ");
int SFS = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите скорость собаки: ");
int dogS = Convert.ToInt32(Console.ReadLine());

while(distance > 10)
{
    if (friends == 1) 
    {
        time = distance / (SFS + dogS); 
        friends = 1;
    }
    else
    {
        time = distance / (FFS + dogS); 
        friends = 2;
    }
    distance = distance - (FFS + SFS) * time;
    count = count + 1;
}
Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз");