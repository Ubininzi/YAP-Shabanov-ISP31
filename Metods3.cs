static void PrintSum(int[] n) {
	foreach (int i in n){
		Console.Write($"{i} ");
	}
	Console.WriteLine();
}
static int[] GetCubes(int start,int end){
	int[] n=new int[end-start+1];
	int c = 0;
	for (int i = start; i <= end; i++,c++){
		n[c] = i * i;
	}
	return n;
}

int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());
PrintSum(GetCubes(startValue, endValue));  
