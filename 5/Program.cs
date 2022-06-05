Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine ();

if(username.ToLower () == "masha")
{
     Console.WriteLine("URA");   
}
else
{
    Console.Write("Privet, ");
    Console.WriteLine(username);
}