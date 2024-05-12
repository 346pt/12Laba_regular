using System.Text.RegularExpressions;

Regex r = new Regex(@"\b((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b");
string text1 = "ip = 145.92.137.11";
string text2 = "ip = 255.255.240.0";
string text3 = "ip = 217.9142.131";
string text4 = "ip = 142.9.199.545";
string text5 = "ip = 317.9.191.133";
Console.WriteLine(r.IsMatch(text1));
Console.WriteLine(r.IsMatch(text2));
Console.WriteLine(r.IsMatch(text3));
Console.WriteLine(r.IsMatch(text4));
Console.WriteLine(r.IsMatch(text5));