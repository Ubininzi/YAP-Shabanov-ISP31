
static void Coder(string str){
    SortedDictionary<char, SortedSet<int>> MAP = new SortedDictionary<char, SortedSet<int>> ();
    int i = 0;
    foreach(char c in str){
        if (MAP.ContainsKey(c)){
            MAP[c].Add(i);
        }else{
            MAP[c] = new SortedSet<int>();
            MAP[c].Add(i);
        }
        i++;
    }
    SortedSet<int> abba = new SortedSet<int>();
    ICollection<char> chars= MAP.Keys;
    foreach(char c in chars){
        Console.Write($"{c} ");
        foreach(int id in MAP[c]){
            Console.Write($"{id} ");
        }
    }
}
Coder("даабввв");
