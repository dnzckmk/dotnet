using ClassLibrary;

Console.WriteLine("Type 'exit' to close the app.");
string text;
do {
    Console.Write("Enter your username: ");
    text = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(text))
        Console.WriteLine("Please enter valid username.");
    else if(text == "exit")
        Environment.Exit(0);
}
while (String.IsNullOrWhiteSpace(text));

//Path of WinForm App
string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
string formsAppPath = Path.GetDirectoryName(location.Substring(0, location.IndexOf("ConsoleApp"))) + "\\WindowsFormsApp\\bin\\Debug\\WindowsFormsApp.exe";

//Concat text
string message = GreetLibrary.GreetUser(text);
Console.WriteLine(message);

System.Diagnostics.Process.Start(formsAppPath, message);
