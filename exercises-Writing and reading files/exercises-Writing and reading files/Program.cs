using System;
using System.IO;
using System.Threading.Tasks;



namespace exercises_Writing_and_reading_files
{
    class Program
    {
        public static int CheckNumber()
        {
            int n;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                {
                    return n;
                }
                else
                {
                    Console.WriteLine("Ошибка!!!Введите корректные данные");
                }
            }
            while (true);
        }
        public static string CheckString()
        {
            string name;
            string Error = "`1234567890-=[];' ,./~!@#$%^&*()_+{}:?";
            bool Error2;
            do
            {
                Error2 = true;
                name = Console.ReadLine();
                if (name == "")
                {
                    Error2 = false;
                }
                foreach (char item1 in name)
                {
                    foreach (char item2 in Error)
                    {
                        if (item1 == item2)
                        {
                            Error2 = false;
                        }
                    }
                }
                if (!Error2)
                {
                    Console.WriteLine("Ошибка! Повторите ввод:");
                }
            } while (!Error2);
            name = name.ToLower();
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        static void Main(string[] args)
        {
            Client client = new Client();
            bool finish = true;
            do
            {
                Console.WriteLine("выберите действия");
                Console.WriteLine("1 Добавить записи");
                Console.WriteLine("2 Читать данные из файла");
                Console.WriteLine("3 Выход из приложения");
                Console.WriteLine("Выберите одно из выше указанных действий: ");
                string number = Console.ReadLine();
                try
                {
                    switch (number)
                    {
                        case "1":
                            Console.WriteLine("1)Добавить кликента в текстовой файл нажмите\n2)Добавить кликента в Excel файл нажмите");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    client.Add_TXT();
                                    break;
                                }
                                if (number == "2")
                                {
                                    client.Add_CSV();
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);
                            break;
                        case "2":
                            Console.WriteLine("1)Читать данные из текстового файла нажмите\n2)Читать данные из Excel файла нажмите");
                            number = Console.ReadLine();
                            do
                            {
                                if (number == "1")
                                {
                                    client.Read_TXT();
                                    break;
                                }
                                if (number == "2")
                                {
                                    client.Read_CSV();
                                    break;
                                }
                                else { Console.WriteLine("Ошибка!!!Введите 1 или 2"); }
                                break;
                            } while (true);
                            break;
                        case "3":
                            Console.WriteLine("Выход из приложения");
                            finish = false;
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка!!!Введите одно из выше указанных действий");
                }
            }
            while (finish == true);
        }
    }
}













