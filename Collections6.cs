static void Matematic(int[] n){
	for (int i = 0; i < n.Length-1; i++){
		for (int j = n[i]+1; j < n[i+1]; j++){
			Console.Write($"{j} ");
		}
	}
}
