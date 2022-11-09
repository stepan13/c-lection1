Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Это маша");
}
else
{
    Console.WriteLine("Это не маша: ");
    Console.WriteLine(username);
}
