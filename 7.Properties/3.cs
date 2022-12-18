using System;
Date d = new Date(32, 13, 2000);
d.Print();
d.Previous().Print();
d.PrintBackward(3);
class Date{
	public int day;
	public int month;
	public int year;
	public Date() { day = 1; month = 1; year = 1; }
	public Date(int day, int month, int year){
		if (day > 0) { this.day = day; }
		else if (day == 0) { this.month = month - 1;this.day = DayInMonth(); }
		else { this.day = 1; }

		if (month > 0 && day != 0) { this.month = month; }
		else if (month == 0) { this.month = 12;this.year = year-1; } 
		else { this.month = 1; }

		if (year > 0 && month != 0) { this.year += year; }
		else { this.year = 1; }
		Normalize();
	}
	public void Normalize(){
		if (!((day>0&&day<=DayInMonth())&&(month>0&&month<=12)&&year>0)){
			int d = day, m = month, y = year;
			day = d % DayInMonth();
			month = ((d / DayInMonth()) + m) % 12;
			year = y + (m / 12);
		}

	}
	public void Print(){
		SortedDictionary<int,string> months = new SortedDictionary<int, string>();
		months.Add(1, "January");
        months.Add(2, "February");
        months.Add(3, "March");
        months.Add(4, "April");
        months.Add(5, "May");
        months.Add(6, "June");
        months.Add(7, "July");
        months.Add(8, "August");
        months.Add(9, "September");
        months.Add(10, "October");
        months.Add(11, "November");
        months.Add(12, "December");
        Console.WriteLine($"The {day} of {months[month]} {year}");
	}
	public int DayInMonth(){
		switch(month)
		{
			case 2:
				return IsIntercalaryYear() ? 29 : 28;
			case 4:
			case 6:
			case 9:
			case 11:
				return 30;
			default:
				return 31;
		}
	}
	public bool IsIntercalaryYear(){
		return (year % 400 == 0 || year % 4 == 0 && year % 100 != 0);
	}
	public Date Next(){
		return new Date(day+1, month, year);
	}
	public Date Previous(){
		return new Date(day-1, month, year);
	}
    public void PrintForward(int n){
        Date dat = this;
        for (int i = 0; i < n; i++){
            dat.Next().Print();
            dat = dat.Next();
        }
    }
    public void PrintBackward(int n){
		Date dat = this;
		for (int i = 0; i < n; i++){
			dat.Previous().Print();
			dat = dat.Previous();
		}
	}
}
