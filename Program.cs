string hello = "Dobar Dan.";
string poruka = "Ovo je poruka.";

Console.WriteLine(hello);
Console.WriteLine(poruka);
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Tip nazivVarijable = vrijednost 
//int number = 120;
double decimalNum = 3.14566;
bool trueFalse = false;

int number = 12011;
string valuta = "180";

//Casting, parsiranje
string result = ((number + int.Parse(valuta))/ 100).ToString();
string booleanString = trueFalse.ToString();
string doubleString = decimalNum.ToString();

int cijeli = (int)decimalNum;
int cijelidva = trueFalse ? 1 : 0;

Console.WriteLine("Cijena proizvoda:" + cijelidva);