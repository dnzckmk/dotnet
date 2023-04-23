
Console.Write("Enter your username: ");
string username = Console.ReadLine();

var location = System.Reflection.Assembly.GetExecutingAssembly().Location;
var formsAppPath = Path.GetDirectoryName(location.Substring(0, location.IndexOf("ConsoleApp"))) + "\\WindowsFormsApp\\bin\\Debug\\WindowsFormsApp.exe";

System.Diagnostics.Process.Start(formsAppPath, username);
