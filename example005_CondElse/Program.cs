Console.WriteLine("Type your name");
string username = Console.ReadLine();

if(username.ToLower() == "timur")
{
    Console.WriteLine("Welcome Timur!");
}
else
{
    Console.Write("Hello,");
    Console.WriteLine(username);
}