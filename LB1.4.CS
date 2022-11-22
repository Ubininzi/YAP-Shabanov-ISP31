int n = Convert.ToInt32(Console.ReadLine());
int hrs = 12; int mins = 30;
if (n != 0){
    mins = 5 * (n + 1);
    hrs += (mins / 60) + n;
    mins %= 60;
    hrs %= 24;
} 
Console.WriteLine($"{hrs}:{mins}");
