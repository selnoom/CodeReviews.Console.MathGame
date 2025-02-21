using MathGameConsole;

string userName;
Console.WriteLine("Hello! Please tell me your name.");
userName = Helper.GetNonEmptyString();
Console.Clear();

Menu menu = new Menu();

menu.ShowMenu(userName);