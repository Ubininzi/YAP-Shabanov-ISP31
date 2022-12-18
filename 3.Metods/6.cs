//выводит с перестановкой множителей
static void VasyaStyle(int num){
	int[] n = new int[3] {2,3,7};
	for (int a = 0; a < 3; a++){
		for (int b = 0; b < 3; b++){
			for (int c = 0; c < 3; c++){
				if (n[a] * n[b] + n[c] ==num){
					Console.WriteLine($"{n[a]}*{n[b]}+{n[c]}");
				}
			}
		}
	}
}


int number = int.Parse(Console.ReadLine());
VasyaStyle(number);
