namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            string day;

            while (isExit == false)
            {
                Console.WriteLine("Напишите день недели для начала программы или exit для завершения:");
                Console.Write("");
                day = Console.ReadLine();

                switch (day)
                {
                    case "понедельник":
                        Console.WriteLine("Идем в магазин");
                        break;
                    case "вторник":
                        Console.WriteLine("Едем за город");
                        break;
                    case "среда":
                        Console.WriteLine("Читаем книги");
                        break;
                    case "четверг":
                        Console.WriteLine("Смотрим фильм");
                        break;
                    case "пятница":
                        Console.WriteLine("Убираемся дома");
                        break;
                    case "суббота":
                        Console.WriteLine("Идем в бассейн");
                        break;
                    case "воскресенье":
                        Console.WriteLine("Выходной");
                        break;
                    case "exit":
                        Console.WriteLine("выход из приложения");
                        isExit = true;
                        break;
                        default: 
                        Console.WriteLine("Нет такого дня");
                        break;
                }
            }
        }
    }
}