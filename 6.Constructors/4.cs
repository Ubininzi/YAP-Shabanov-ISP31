denga d = new denga("25", "коп.");
denga f = new denga("10", "р.", "76", "коп.");
d = denga.Sum(d, f);
d.Print();
d=denga.Difference(d, f);
d.Print();
denga c = new denga("10", "р.", "15", "коп.");
c.PrintTransferCost(0.05);

class denga{
	public int rubl;
	public int copeica;
	public denga(){
		rubl = 0;
		copeica = 0;
	}
	public denga(string deng, string str){
		if (str=="р."){
			rubl = int.Parse(deng);
		}
		if (str == "коп.")
		{
			rubl += int.Parse(deng) / 100;
			copeica = int.Parse(deng) % 100;
		}
	}
	public denga (string rubl,string str1,string copeica,string str2){
		if (str1 == "коп." && str2 == "р."){
			Console.WriteLine("рубли и копейки перепутаны!");
		}else if (int.Parse(rubl) < 0 || int.Parse(copeica) < 0){
			Console.WriteLine("Не может быть отрицательным!");
		}else {
			this.rubl = int.Parse(rubl) + int.Parse(copeica) /100;
			this.copeica = int.Parse(copeica) %100;
		}
		
	}
	public void Print(){
		if (rubl == 0) { Console.WriteLine($"{copeica} коп. "); }
		else {Console.WriteLine($"{rubl} р. {copeica} коп. ");}
	}
	static public denga Sum(denga d1,denga d2) {
        return new denga((d1.rubl + d2.rubl).ToString(), "р.", (d1.copeica + d2.copeica).ToString(), "коп.");
    }
    static public denga Difference(denga d1, denga d2){
        return new denga(((d1.rubl*100)+d1.copeica - (d2.rubl * 100)+d2.copeica).ToString(), "коп.");
    }
	public void PrintTransferCost(double comiss){
		denga d = new denga(Convert.ToInt32((rubl*100+copeica)*(comiss+1)).ToString(),"коп.");
		d.Print();
	}
}
