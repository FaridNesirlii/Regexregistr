using System.Text.RegularExpressions;


object[] user = new object[0];

Console.WriteLine("Register!");
tryagain: 
Console.Write("Username:");
string username= Console.ReadLine();
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Surname: ");
string surname = Console.ReadLine();
Console.Write("Age: ");
string age = Console.ReadLine();
Console.Write("Number: ");
string number = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("password: ");
string password = Console.ReadLine();

Regex regexusername = new Regex(@"^[a-z]\S");
Match regexnmatch = regexusername.Match(username);

Regex regexname = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
Match regexnamematch = regexname.Match(name);

Regex regexsurname = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
Match regexsurnamematch = regexsurname.Match(surname);

Regex regexage = new Regex(@"^[1-8]{2}");
Match regexagematch = regexage.Match(age);

Regex regexnumber = new Regex(@"^(\+994\-[1-9]{2}\-[1-9]{3}\-[1-9]{2}\-[1-9]{2})");
Match regexnumbermatch = regexnumber.Match(number);

Regex regexemail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
Match regexemailmatch = regexemail.Match(email);

Regex regexpassword = new Regex(@"^.*");
Match regexpasswordmatch = regexage.Match(password);

if (regexsurnamematch.Success && regexpasswordmatch.Success && regexemailmatch.Success && regexnamematch.Success && regexnumbermatch.Success && regexnmatch.Success && regexagematch.Success )
{
    var users = new { username = username, name = name, surname = surname, age = age, number = number, email = email, password = password };
    //Array.Resize(ref user, user. + 1);
    //user[user.Length - 1] = user;
    //Console.WriteLine("User created !");
    Array.Resize(ref user, user.Length + 1);
    user[user.Length-1] = users;
    Console.WriteLine("Welcome new user!!!");
}
else
{
    Console.WriteLine("Invalid valudation");
    //Console.Clear();
    goto tryagain;
}