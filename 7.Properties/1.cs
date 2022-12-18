var tree2 = new Tree("береза", 80);
tree2.Print();
var tree1 = new Tree("сосна", -6);


class Tree
{
    public string Type;
    public int Height;
    public Tree() { Type = "undefined"; Height = 0; }
    public Tree(string type, int height) {
        if (height>=0){Type = type; Height = height;}
        else{throw new Exception("дерево не может быть отрицательной высоты!");}
    }
    public void Print() { 
        Console.WriteLine($"дерево вида {Type} высотой {Height}");
    }

}
