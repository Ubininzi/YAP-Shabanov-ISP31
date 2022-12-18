Coordinates spider = new Coordinates();
Coordinates fly = new Coordinates();
Console.WriteLine("корды мухи: ");
fly.enterCoordinates();
Console.WriteLine("корды паука: ");
spider.enterCoordinates();
if (fly.y == 0)
{
    Console.WriteLine("по прямой: ");
    Console.WriteLine(distance(fly,spider));
    Console.WriteLine("пауку нужно пройти: ");
    Console.WriteLine(spiderWay(fly, spider));
}
else
{
    Console.WriteLine("муха не спит");
}
double distance(Coordinates crd1, Coordinates crd2)
{
    return Math.Round(Math.Sqrt(Math.Pow(crd2.x - crd1.x, 2) + Math.Pow(crd2.y - crd1.y, 2) + Math.Pow(crd2.z - crd1.z, 2)),5);
}
double spiderWay(Coordinates crd1, Coordinates crd2)
{
    return Math.Round(Math.Sqrt(Math.Pow(crd2.x - crd1.x, 2) + Math.Pow(crd2.z - crd1.z, 2))+Math.Abs(crd2.y-crd1.y),5);
}
class Coordinates
{
    public float x;
    public float y;
    public float z;
    public Coordinates(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public Coordinates()
    {
        this.x = 0;
        this.y = 0;
        this.z = 0;
    }
    public void enterCoordinates()
    {
        Console.WriteLine("введите x:");
        x = float.Parse(Console.ReadLine());
        Console.WriteLine("введите y:");
        y = float.Parse(Console.ReadLine());
        Console.WriteLine("введите z:");
        z = float.Parse(Console.ReadLine());
    }
}
