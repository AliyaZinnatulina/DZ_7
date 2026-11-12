using DZ7_Tumakov.Classes;
using DZ7_Tumakov.Enums;

namespace DZ7_Tumakov
{
    internal class Program
    {
        /// <summary>
        /// Переворачивает строку задом наперед.
        /// </summary>
        /// <param name="input">Исходная строка</param>
        /// <returns>Перевернутая строка</returns>
        static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            string reverseString = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            return reverseString;
        }

        /// <summary>
        /// Проверяет реализацию интерфейса с помощью оператора is
        /// </summary>
        /// <param name="o"></param>
        static void IsFormattable(object obj)
        {
            if (obj is IFormattable)
            {
                Console.WriteLine("С помощью оператора is");
                Console.WriteLine("Объект реализует интерфейс IFormattable");
            }
            else 
            {
                Console.WriteLine("С помощью оператора is");
                Console.WriteLine("Объект не реализует интерфейс IFormattable");
            }
        }

        /// <summary>
        /// Проверяет реализацию интерфейса с помощью оператора as
        /// </summary>
        /// <param name="o"></param>
        static void AsFormattable(object obj)
        {
            IFormattable formattable = obj as IFormattable;
            if (formattable != null)
            {
                Console.WriteLine("С помощью оператора as");
                Console.WriteLine("Объект реализует интерфейс IFormattable");

                if (obj is DateTime)
                {
                    Console.WriteLine($"Отформатированное значение: {formattable.ToString("dd.MM.yyyy HH:mm", null)}");
                }
                else
                {
                    Console.WriteLine($"Отформатированное значение: {formattable.ToString("N1", null)}");
                }
            }
            else
            {
                Console.WriteLine("С помощью оператора as");
                Console.WriteLine("Объект не реализует интерфейс IFormattable");
            }
        }

        static void SearchMail(ref string s)
        {
            int hashIndex = s.IndexOf("#");
            if (hashIndex != -1)
            {
                s = s.Substring(hashIndex + 1).Trim();
            }
        }

        // Упражнение №8.1
        static void Exercise81()
        {
            Console.WriteLine("Упражнение №8.1");

            BankAccount accountFirst = new BankAccount();

            Console.Write("Введите баланс первого счёта: ");
            bool isBalanceFirst = decimal.TryParse(Console.ReadLine(), out decimal balanceFirst);

            while (!isBalanceFirst)
            {
                Console.Write("Ошибка! Введите число: ");
                isBalanceFirst = decimal.TryParse(Console.ReadLine(), out balanceFirst);
            }
            accountFirst.Balance = balanceFirst;

            Console.Write("Введите тип первого банковского счёта: ");
            bool isTypeFirst = Enum.TryParse(Console.ReadLine(), true, out AccountType accountTypeFirst);

            while (!isTypeFirst)
            {
                Console.Write("Ошибка! Введите тип первого банковского счёта (Текущий или Сберегательный): ");
                isTypeFirst = Enum.TryParse(Console.ReadLine(), true, out accountTypeFirst);
            }
            accountFirst.AccountType = accountTypeFirst;

            accountFirst.PrintBankAccountInfo();

            Console.Write("Введите сумму, которую хотите снять с первого счёта: ");
            bool isWithDrawAmountFirst = decimal.TryParse(Console.ReadLine(), out decimal WithDrawAmountFirst);

            while (!isWithDrawAmountFirst)
            {
                Console.Write("Ошибка! Введите сумму, которую хотите снять с первого счёта, числом: ");
                isWithDrawAmountFirst = decimal.TryParse(Console.ReadLine(), out WithDrawAmountFirst);
            }
            accountFirst.WithDraw(WithDrawAmountFirst);

            Console.Write("Введите сумму, на которую хотите пополнить первый счёт: ");
            bool isDepositAmountFirst = decimal.TryParse(Console.ReadLine(), out decimal DepositAmountFirst);

            while (!isDepositAmountFirst)
            {
                Console.Write("Ошибка! Введите сумму пополнения первого счёта числом: ");
                isDepositAmountFirst = decimal.TryParse(Console.ReadLine(), out DepositAmountFirst);
            }
            accountFirst.Deposit(DepositAmountFirst);

            BankAccount accountSecond = new BankAccount();

            Console.Write("\nВведите баланс второго счёта: ");
            bool isBalanceSecond = decimal.TryParse(Console.ReadLine(), out decimal balanceSecond);

            while (!isBalanceSecond)
            {
                Console.Write("Ошибка! Введите число: ");
                isBalanceSecond = decimal.TryParse(Console.ReadLine(), out balanceSecond);
            }
            accountSecond.Balance = balanceSecond;

            Console.Write("Введите тип второго банковского счёта: ");
            bool isTypeSecond = Enum.TryParse(Console.ReadLine(), true, out AccountType accountTypeSecond);

            while (!isTypeSecond)
            {
                Console.Write("Ошибка! Введите тип второго банковского счёта (Текущий или Сберегательный): ");
                isTypeSecond = Enum.TryParse(Console.ReadLine(), true, out accountTypeSecond);
            }
            accountSecond.AccountType = accountTypeSecond;

            accountSecond.PrintBankAccountInfo();

            Console.Write("Введите сумму, которую хотите снять со второго счёта: ");
            bool isWithDrawAmountSecond = decimal.TryParse(Console.ReadLine(), out decimal WithDrawAmountSecond);

            while (!isWithDrawAmountSecond)
            {
                Console.Write("Ошибка! Введите сумму, которую хотите снять со второго счёта, числом: ");
                isWithDrawAmountSecond = decimal.TryParse(Console.ReadLine(), out WithDrawAmountSecond);
            }
            accountSecond.WithDraw(WithDrawAmountSecond);

            Console.Write("Введите сумму, на которую хотите пополнить второй счёт: ");
            bool isDepositAmountSecond = decimal.TryParse(Console.ReadLine(), out decimal DepositAmountSecond);

            while (!isDepositAmountSecond)
            {
                Console.Write("Ошибка! Введите сумму пополнения второго счёта числом: ");
                isWithDrawAmountSecond = decimal.TryParse(Console.ReadLine(), out DepositAmountSecond);
            }
            accountSecond.Deposit(DepositAmountSecond);

            Console.Write("\nВведите сумму, которую хотите перевести с первого счета на второй: ");
            bool isTransferParsed = decimal.TryParse(Console.ReadLine(), out decimal transferAmount);
            while (!isTransferParsed)
            {
                Console.Write("Ошибка! Введите сумму перевода числом: ");
                isTransferParsed = decimal.TryParse(Console.ReadLine(), out transferAmount);
            }

            accountSecond.TransferMoney(accountFirst, transferAmount);

            accountFirst.PrintBankAccountInfo();
            accountSecond.PrintBankAccountInfo();
        }

        // Упражнение №8.2
        static void Exercise82()
        {
            Console.WriteLine("Упражнение №8.2");
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();

            string reverseString = ReverseString(str);

            Console.WriteLine($"Исходная строка: {str}\nОбратная строка: {reverseString}");
        }

        // Упражнение №8.3
        static void Exercise83()
        {
            Console.WriteLine("Упражнение №8.3");
            Console.Write("Введите имя исходного файла (Files/FileForEx3.txt): ");
            string fileFirst = Console.ReadLine();

            if (!File.Exists(fileFirst))
            {
                Console.WriteLine("Ошибка! Такого файла не существует. Работа программы закончена");
                return; 
            }

            Console.Write("Введите имя выходного файла: ");
            string fileSecond = Console.ReadLine();

            string text = File.ReadAllText(fileFirst);

            string upperText = text.ToUpper();

            File.WriteAllText(fileSecond, upperText);

            Console.WriteLine($"Содержимое файла '{fileFirst}' записано в файл '{fileSecond}' заглавными буквами");
        }

        // Упражнение №8.4
        static void Exercise84()
        {
            Console.WriteLine("Упражнение №8.4");

            int intValue = 12345;
            double doubleValue = 123.45;
            DateTime dateValue = DateTime.Now;
            string stringValue = "Hello, World!";
            BankAccount account = new BankAccount();
            var arrayValue = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("\n\tТест для целого числа");
            IsFormattable(intValue);
            AsFormattable(intValue);

            Console.WriteLine("\n\tТест для дробного числа");
            IsFormattable(doubleValue);
            AsFormattable(doubleValue);

            Console.WriteLine("\n\tТест для даты");
            IsFormattable(dateValue);
            AsFormattable(dateValue);

            Console.WriteLine("\n\tТест для строки");
            IsFormattable(stringValue);
            AsFormattable(stringValue);

            Console.WriteLine("\n\tТест для массива");
            IsFormattable(arrayValue);
            AsFormattable(arrayValue);

            Console.WriteLine("\n\tТест для класса");
            IsFormattable(account);
            AsFormattable(account);
        }

        // Домашнее задание №8.1
        static void Homework81()
        {
            Console.WriteLine("Домашнее задание №8.1");

            string path = "..\\..\\..\\Files\\FileForDZ81.txt";
            string[] lines = File.ReadAllLines(path);

            List<string> email = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                string currentLine = lines[i];
                SearchMail(ref currentLine);
                email.Add(currentLine);
            }

            File.WriteAllLines("EmailFile", email);
            Console.WriteLine("Новый файл, содержащий список адресов электронной почты, успешно сформирован!");
        }

        // Домашнее задание №8.2
        static void Homework82()
        {
            Console.WriteLine("Домашнее задание №8.2");

            Song songFirst = new Song("Do I Wanna Know?", "Arctic Monkeys", null);
            Song songSecond = new Song("Snap Out Of It", "Arctic Monkeys", null);
            Song songThird = new Song("ocean eyes", "Billie Eilish", null);
            Song songFourth = new Song("No. 1 Party Anthem", "Arctic Monkeys", null);

            List<Song> playlist = new List<Song> { songFirst, songSecond, songThird, songFourth };

            Console.WriteLine("Плэйлист:");
            for (int i = 0; i < playlist.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlist[i].Title()}");
            }

            if (songFirst.Equals(songSecond))
            {
                Console.WriteLine("Первые две песни одинаковые");
            }
            else
            {
                Console.WriteLine("Первые две песни разные");
            }
        }

        static void Main(string[] args)
        {
            Exercise81();
            Exercise82();
            Exercise83();
            Exercise84();
            Homework81();
            Homework82();
            Console.ReadKey();
        }
    }
}
