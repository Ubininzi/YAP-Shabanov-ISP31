string NUM1 = Console.ReadLine();
string NUM2 = Console.ReadLine();
int cntr = 0;
for(int i = 0; i < NUM2.Length; i++){
	if (NUM1.Contains(NUM2[i])){
		foreach (char ch in NUM1){
			if (ch == NUM2[i]){
				Console.Write($"{NUM2[i]} ");
			}
		}
	}
}
