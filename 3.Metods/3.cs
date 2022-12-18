static void PrintSum(int[] n){
    int Sum = 0;
    foreach (int i in n){
        Sum+=i;
    }
    Console.WriteLine(Sum);
}
static int[] GetCubes(int start, int end)
{
    int[] n = new int[end - start + 1];
    int c = 0;
    for (int i = start; i <= end; i++, c++)
    {
        n[c] = i * i;
    }
    return n;
}

int startValue = int.Parse(Console.ReadLine());
int endValue = int.Parse(Console.ReadLine());
PrintSum(GetCubes(startValue, endValue));
