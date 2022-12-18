using System.Globalization;

Mystring str = new Mystring(Console.ReadLine());
Console.WriteLine(str.Reverse());
Console.WriteLine(str.UcFirst());
Console.WriteLine(str.UcWords());
class Mystring{
    public Mystring(string str){
        Value = str;
    }
    public string Value;
    public string Reverse(){
        return new string(Value.ToCharArray().Reverse().ToArray());
    }
    public string UcFirst(){
        return Value[0].ToString().ToUpper() + Value.Substring(1);
    }
    public string UcWords() {
        TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
        return ti.ToTitleCase(Value);
    }
}
