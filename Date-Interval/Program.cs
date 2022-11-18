using static System.Net.Mime.MediaTypeNames;

Console.WriteLine($"Введите начальную дату");
string enter = Console.ReadLine();
DateTime first = Dite(enter);
Console.WriteLine($"Введите конечную дату");
string enter2 = Console.ReadLine();
DateTime second = Dite(enter2);
if (first < second)
{
    var interval = second - first;
    Console.WriteLine($"Интервал в днях {interval.Days}");

}

DateTime a = new DateTime();
DateTime date1 = new DateTime();
DateTime Dite(string enter)
{
    while (true)
    {


        string[] words = enter.Split(new char[] { ' ', '.', ':' });
        bool dite3 = int.TryParse(words[0], out int day);
        if (dite3 == false)
        {
            Console.WriteLine($"ошибка");
            continue;
        }
        else
        {
            bool dite2 = int.TryParse(words[1], out int month);
            bool dite = int.TryParse(words[2], out int year);
            if (dite == true && dite2 == true && dite3 == true)
            {
                return date1 = new DateTime(year, month, day);
                break;
            }
            else { Console.WriteLine($"Введиет коректную дату"); }

        }
    }
    return a = new DateTime();
}
