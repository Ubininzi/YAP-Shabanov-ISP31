static void MasOutput(int[] Arr){
    for (int i = 0; i < Arr.Length; i++){
        Console.Write($"{Arr[i]} ");
    }
    Console.WriteLine();
}
static int[] DeltaCoding(int[] Arr){
    int[] AnsArr = new int[Arr.Length];
    AnsArr[0] = Arr[0];
    for (int i = 1; i < Arr.Length; i++){
        AnsArr[i] = Arr[i] - Arr[i-1];
    }
    return AnsArr;
}
static int[] DeltaDeCoding(int[] Arr){
    int[] AnsArr = new int[Arr.Length];
    AnsArr[0] = Arr[0];
    for (int i = 1; i < Arr.Length; i++){
        AnsArr[i] = AnsArr[i - 1] + Arr[i] ;
    }
    return AnsArr;
}

static int[] AhShitHereWeGoAgain(int N,int[] Arr){
    int[] AnsArr = new int[Arr.Length+1];
    int Id=0, min=Arr[0];
    for (int i = 0; i < Arr.Length; i++){
        if (Arr[i]<=min){
            min = Arr[i];
            Id = i;
        }
    }
    AnsArr[Id+1] =N;
    for (int i = Id + 1; i < Arr.Length; i++){
        AnsArr[i+1] = AnsArr[i] + Arr[i];
    }
    for (int i = Id; i >= 0; i--){
        AnsArr[i] = AnsArr[i+1] - Arr[i];
    }
    return AnsArr;
}

int[] Numbers = new int[7] { 10, 9, 8, 7, 6, 5, 4 };
int[] DeltaNumbers = DeltaCoding(Numbers);
int[] DeltaDeNumbers = DeltaDeCoding(DeltaNumbers);
MasOutput(Numbers);
MasOutput(DeltaNumbers);
MasOutput(DeltaDeNumbers);
MasOutput(AhShitHereWeGoAgain(1468, new int[] { 27, -15, 2, 22, 12, -55, 11 }));
