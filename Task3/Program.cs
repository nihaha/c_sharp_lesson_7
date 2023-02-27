using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

/*
 * Используя Visual Studio, создайте проект по шаблону Console Application. 
 * Создайте программу в которой создайте класс «Банковский Счет». 
 * В теле класса создайте следующие поля: дата открытия счета, процентная ставка по счету, 
 * сумма счета. В теле метода создайте следующие методы: Метод, который рассчитывает 
 * количество дней, начиная с даты открытия счета; Метод который выводит информацию о 
 * количестве рассчитанных дней; Метод который рассчитывает сумму, которая будет на счете 
 * через определенное количество лет (количество лет – параметр метода); Метод который 
 * выводит информацию о сумме. Также продумать над конструктором класса. В методе Main() 
 * создайте экземпляр класса «Банковский Счет», присвойте всем полям значение через свойства 
 * доступа, а также на экземпляр класса вызовите методы для отображения количества дней и суммы.
 */
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount clientAccount = new BankAccount("01-01-2016", 12.5, 1650);
            /*clientAccount.OpenDate = DateTime.Parse("01-01-2016");
            clientAccount.InterestRate = 12.5;
            clientAccount.Deposit = 1650;*/
                        
            clientAccount.AccountActiveInfo();
            clientAccount.CurrentTotalInfo();
            clientAccount.Profit(8);

            Console.ReadLine();
        }
    }

    class BankAccount
    {
        public DateTime OpenDate { private get; set; }

        public double InterestRate { private get; set; }

        public double Deposit { private get; set; }

        public BankAccount(string openDate, double interestRate, double deposit) 
        {
            OpenDate = DateTime.Parse(openDate);
            InterestRate = interestRate;
            Deposit = deposit;
        }

        private int AccountLifespan()
        {
            return (DateTime.Now.Date - OpenDate.Date).Days;
        }

        public void AccountActiveInfo()
        {
            Console.WriteLine($"Your account is active for {AccountLifespan()} days");
        }

        public void Profit(int years)
        {
            double profit = CurrentTotal();
            int FutureYear = DateTime.Now.AddYears(years).Year;
            for (int i = DateTime.Now.Year; i < FutureYear; i++)
            {
                profit += profit * (InterestRate / 100);
            }

            Console.WriteLine($"Your profit in {years} years will be ${Math.Round(profit, 2)}");
        }

        private double CurrentTotal()
        {
            double total = Deposit;
            for (int i = DateTime.Now.Year; i > OpenDate.Year; i--)
            {
                total += total * (InterestRate / 100);
            }

            return total;
        }

        public void CurrentTotalInfo()
        {
            Console.WriteLine($"Your current balance is ${Math.Round(CurrentTotal())}");
        }
    }
}
