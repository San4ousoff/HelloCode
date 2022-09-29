// Особое приветствие определенного пользователя по имени
//string username = "Маша";
//Console.WriteLine(username);
Console.Write("Введите Ваше имя: ");
//string anothername = Console.ReadLine();
string username = Console.ReadLine();
//if (username == anothername)
if (username.ToLower() == "маша")
{
    Console.WriteLine("Божечки мои, да это же Маша!");
}
else
{
    Console.Write("А, это опять ты, ");
//    Console.WriteLine(anothername);
    Console.WriteLine(username);
}