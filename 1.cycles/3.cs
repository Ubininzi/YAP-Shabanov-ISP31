int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < N; i++){
    Console.Write(new string(' ', N - i - 1));
    Console.Write(new string('*', 2*(i + 1)-1));
    Console.WriteLine();
}
