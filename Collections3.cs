static List<string> GetList(int n){
	string[] AnsArr = new string[n];
	Random rnd = new Random();
	for (int i = 0; i < n; i++){
		switch (rnd.Next(0, 3)){
			case 0:AnsArr[i] = (rnd.Next(0,100).ToString());break;
			case 1:AnsArr[i] = ((rnd.NextDouble()*100).ToString());break;
			case 2:AnsArr[i] = ((char)rnd.Next('a', 'z')).ToString();break;
		}
	}
	return AnsArr.ToList();
}

List<string> Arr = GetList(10);
foreach(string i in Arr) { Console.Write($"{i} "); }
