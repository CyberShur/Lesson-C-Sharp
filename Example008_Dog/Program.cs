int distance = 10000, FFS = 1, SFS = 2, dogS = 5, friends = 2, count = 0, time = 0;

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