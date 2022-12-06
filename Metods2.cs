static void Factorize(int N){
	for (int i = 1; i < Math.Sqrt(N); i++){
		if (N%i==0){
			Console.WriteLine($"{N}={i}*{N/i}");
		}
	}
}
