Console.Write("Введите имя ");
string username = Console.ReadLine();

if (username.ToLower() == "милания")
{
    Console.WriteLine("Ура это Милания");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}