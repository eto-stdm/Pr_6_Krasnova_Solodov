using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        private BankAccount() { }

        /// <summary>
        /// Конструктор.
        /// </summary>
        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        /// <summary>
        /// Этот метод выводит имя покупателя.
        /// </summary>
        public string CustomerName
        {
            get { return m_customerName; }
        }

        /// <summary>
        /// Этот метод выводит баланс.
        /// </summary>
        public double Balance
        {
            get { return m_balance; }
        }

        /// <summary>
        /// Этот метод расчитывает дебет.
        /// </summary>
        /// <param name="amount">Число, обозначающее дебет</param>
        /// <exception cref="ArgumentOutOfRangeException">Выход за пределы диапазона (меньше 0 или больше тек. баланса)</exception>
        /// <returns>Разность баланса и дебета</returns>
        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance -= amount;
        }

        /// <summary>
        /// Этот метод расчитывает кредит.
        /// </summary>
        /// <param name="amount">Число, обозначающее кредит</param>
        /// <returns>Сумма дебета и кредита</returns>
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Roman Abramovich", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
            Console.ReadLine();
        }
    }
}
