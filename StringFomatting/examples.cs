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
