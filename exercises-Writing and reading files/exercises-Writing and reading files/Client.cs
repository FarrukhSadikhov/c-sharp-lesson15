using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Threading.Tasks;

namespace exercises_Writing_and_reading_files
{
    class Client
    {
        public int Id { get; set; }
        public int Passport { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Payment { get; set; }
        public void Add_CSV()
        {
            string path = @"C:\Client";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("Сколько клиентов хотите внести: ");
            int n = Program.CheckNumber();
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите Id: ");
                Id = Program.CheckNumber();
                Console.WriteLine("Введите номер паспорта  AZE/AA: ");
                Passport = Program.CheckNumber();
                Console.WriteLine("Введите имя:");
                Name = Program.CheckString();
                Console.WriteLine("Введите возраст: ");
                Age = Program.CheckNumber();
                Console.WriteLine("Введите платёж: ");
                Payment = Program.CheckNumber();
                arr[i] = $"Id:{Id}\nНомер паспорта:{Passport}\nИмя:{Name}\nВозраст:{Age}\nПлатёж:{Payment}\n";
            }
            using (FileStream fstream = new FileStream($"{path}\\note.csv", FileMode.OpenOrCreate)) { }
            string writePath = @"C:\Client\note.csv";
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {

                    using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.UTF8))
                    {
                        sw.Write(arr[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Запись выполнена");
        }
        public void Read_CSV()
        {
            string path = @"C:\Client";
            using (FileStream fstream = File.OpenRead($"{path}\\note.csv")) { }
            string readPath = @"C:\Client\note.csv";
            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Add_TXT()
        {
            string path = @"C:\Client";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("Сколько клиентов хотите внести: ");
            int n = Program.CheckNumber();
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Введите Id: ");
                Id = Program.CheckNumber();
                Console.WriteLine("Введите номер паспорта  AZE/AA: ");
                Passport = Program.CheckNumber();
                Console.WriteLine("Введите имя:");
                Name = Program.CheckString();
                Console.WriteLine("Введите возраст: ");
                Age = Program.CheckNumber();
                Console.WriteLine("Введите платёж: ");
                Payment = Program.CheckNumber();
                arr[i] = $"Id:{Id}\nНомер паспорта:{Passport}\nИмя:{Name}\nВозраст:{Age}\nПлатёж:{Payment}\n";
            }
            using (FileStream fstream = new FileStream($"{path}\\note.txt", FileMode.OpenOrCreate)) { }
            string writePath = @"C:\Client\note.txt";
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {

                    using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.UTF8))
                    {
                        sw.Write(arr[i]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Запись выполнена");
        }
        public void Read_TXT()
        {
            string path = @"C:\Client";
            using (FileStream fstream = File.OpenRead($"{path}\\note.txt")) { }
            string readPath = @"C:\Client\note.txt";
            try
            {
                using (StreamReader sr = new StreamReader(readPath))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
