static void BetweenZeros(int[] Arr ){
    int start, end,c=0;
    start = Array.FindIndex(Arr, 0, Arr.Length, x => x == 0);
    end = Array.FindIndex(Arr, start+1, Arr.Length-start-1, x => x == 0);
    int[] AnsArr = new int[end-start-1];
    for (int i = start+1; i < end; i++,c++){
        AnsArr[c] = Arr[i];
    }
    Array.Sort(AnsArr);
    foreach(int i in AnsArr) { 
        Console.Write($"{i} ");
    }
}

int[] ints= new int[10] { 1,2,3,0,4,9,8,0,9,4};
BetweenZeros(ints);
