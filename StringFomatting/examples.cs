//will output to console
/*Generating invoices for customer "Contoso Corp" ...

Invoice: 1021		Complete!
Invoice: 1022		Complete!

Output Directory:	
c:\invoices

日本の請求書を生成するには：
	c:\invoices\app.exe -j
*/
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.Write(@"c:\invoices");//verbatim. no need to escape char/
// To generate Japanese invoices:
//Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
//user command to run an application. \u for unicode
Console.WriteLine(@"c:\invoices\app.exe -j");

//string interpolation
string firstName ="Bob";
string message = $"Hello {firstName}!";
Console.WriteLine(message);

int version = 11;
string updateText = "Update to Windows";
string message = $"{updateText}{version}";
Console.WriteLine(message);

//verbatim and string literal
string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

//section challenge
/*output will be
View English output:
    c:\Excercise\ACME\data.txt
Посмотреть русский вывод:
    c:\Excercise\ACME\ru-RU\data.txt
*/
string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine(@"View English output:
    c:\Excercise\"+projectName+@"\data.txt");
Console.WriteLine($@"{russianMessage}:
    c:\Excercise\{projectName}\ru-RU\data.txt");

//convert celcius and fahrenheit
int fahrenheit = 94;
decimal celcius = ((decimal)fahrenheit-32)*((decimal)5/(decimal)9);
Console.WriteLine($@"
Fahrenheit: {fahrenheit}
Celcius: {celcius}");
