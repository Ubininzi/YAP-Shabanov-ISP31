char[] chars = Console.ReadLine().ToCharArray();
int[] NUM =Array.ConvertAll(chars, c => (int)Char.GetNumericValue(c));
string str = new string(chars);
str=str.Insert(0, NUM.Max().ToString());
str=str.Insert(0, NUM.Min().ToString());
Console.WriteLine(str.ToCharArray().Reverse().ToArray());
