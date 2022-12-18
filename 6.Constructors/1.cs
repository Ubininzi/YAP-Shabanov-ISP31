var myWatch = new Watch("Casio", "electronic", 15.99M);
myWatch.Print();
class Watch
{
    public string brand;
    public string type;
    public decimal price;
    public Watch(string brand, string type, decimal price){
        this.brand = brand;
        this.type = type;
        this.price = price;
    }
    public void Print()
    {
        Console.WriteLine(brand);
        Console.WriteLine(type);
        Console.WriteLine(price);
    }
}
