using DZ7_Tumakov.Enums;

namespace DZ7_Tumakov.Classes
{
    public class BankAccount
    {
        private int _accountNumber;
        private decimal _balance;
        private AccountType _accountType;
        private static int _bankAccountNumber = 0;

        public BankAccount()
        {
            _accountNumber = GenerateAccountNumber();
        }

        /// <summary>
        /// Статический метод, который увеличивает счетчик и возвращает новый номер
        /// </summary>
        /// <returns>Новый уникальный номер</returns>
        private static int GenerateAccountNumber()
        {
            return ++_bankAccountNumber;
        }

        public int AccountNumber
        {
            get { return _accountNumber; }
        }

        public decimal Balance
        {
            get { return _balance; }
            // для записи
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Баланс не может быть отрицательным");
                }
                _balance = value;
            }
        }

        public AccountType AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }

        }

        public int BankAccountNumber()
        {
            return _bankAccountNumber++;
        }

        public void WithDraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ошибка! Сумма списания должна быть больше нуля");
                return;
            }
            else if (amount > _balance)
            {
                Console.WriteLine("Ошибка! Деньги не списаны со счёта: недостаточно средств");
            }
            else
            {
                _balance -= amount;
                Console.WriteLine($"Сумма успешно списана. Текущий баланс: {_balance}");
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ошибка! Сумма пополнения должна быть больше нуля");
                return;
            }
            _balance += amount;
            Console.WriteLine($"Сумма успешно внесена. Текущий баланс: {_balance}");

        }

        /// <summary>
        /// Переводит деньги с другого счета на текущий.
        /// </summary>
        /// <param name="sourceAccount">Счет, с которого снимаются деньги</param>
        /// <param name="amount">Сумма перевода</param>
        public void TransferMoney(BankAccount sourceAccount, decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Ошибка! Сумма перевода должна быть больше нуля");
                return;
            }

            if (sourceAccount.AccountNumber == AccountNumber)
            {
                Console.WriteLine("Ошибка! Нельзя перевести деньги на тот счёт, с которого они снимаются");
                return;
            }

            if (sourceAccount.Balance >= amount)
            {
                sourceAccount.Balance -= amount;

                //прибавляется к счёту, у которого вызвали метод
                this.Balance += amount;

                Console.WriteLine($"Выполнен перевод в размере {amount} руб. со счёта {sourceAccount.AccountNumber} на счёт {this.AccountNumber}");
            }
            else
            {
                Console.WriteLine("Ошибка! Перевод не выполнен: недостаточно средств на счёте, с которого собирались перевести деньги");
            }
        }

        /// <summary>
        /// Выводит информацию о банковском аккаунте пользователя
        /// </summary>
        public void PrintBankAccountInfo()
        {
            Console.WriteLine($"\nНомер счёта: {AccountNumber}\nБаланс: {Balance}\nТип банковского счёта: {AccountType}");
        }
    }
}
