const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

string spanOpen = "<span>";
string spanClosing = "</span>";

int quantityOpen = input.IndexOf(spanOpen);
int quantityClosing = input.IndexOf(spanClosing);
quantityOpen += spanOpen.Length;
int quantityLenght = quantityClosing - quantityOpen; 
quantity = input.Substring(quantityOpen, quantityLenght);

string div = "<div>"; 
output = input.Substring(div.Length);
int divClosing = output.IndexOf("</div>");
output = output.Remove(divClosing, div.Length + 1);
output = output.Replace("&trade", "&reg");

Console.WriteLine("Quantity: " + quantity);
Console.WriteLine("Output: " + output);