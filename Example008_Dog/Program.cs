int friends = 2, count = 0, time = 0; //distance = 10000

Console.Write("Введите дистанцию: ");
string distance12 = Console.ReadLine();
int distance = Int32.Parse(distance12);

Console.Write("Введите скорость первого друга: ");
string FFS1 = Console.ReadLine();
int FFS = Int32.Parse(FFS1);

Console.Write("Введите скорость второго друга: ");
string SFS1 = Console.ReadLine();
int SFS = Int32.Parse(SFS1);

Console.Write("Введите скорость собаки: ");
string dogS1 = Console.ReadLine();
int dogS = Int32.Parse(dogS1);

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