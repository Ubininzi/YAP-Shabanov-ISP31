string A = Console.ReadLine();
A += Console.ReadLine();
SortedDictionary<char,int> MAP= new SortedDictionary<char,int>();
foreach(char c in A){
	if (MAP.ContainsKey(c)){
		MAP[c] += 1;
	}else {
		MAP.Add(c, 1);
	}
}
ICollection<char> chars = MAP.Keys;
Console.Write("уникальные элементы: ");
foreach(char c in chars){
	if (MAP[c]==1){
		Console.Write($"{c} ");
	}
}
