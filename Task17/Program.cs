using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();
            bankAccount1.Write(1234560, 154800, "Андреев В.В.");
            bankAccount1.Print();
            Console.WriteLine();
            BankAccount<string> bankAccount2 = new BankAccount<string>();
            bankAccount2.Write("1234569", 297300, "Семенов А.А.");
            bankAccount2.Print();
            Console.ReadLine();
        }
    }
    class BankAccount<T>
    {
        private T number;
        private double balance;
        private string name;
        public T Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public void Write(T number, double balance, string fio)
        {
            Name = (string)Convert.ChangeType(Console.ReadLine(), typeof(string));
            Number = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Balance = (double)Convert.ChangeType(Console.ReadLine(), typeof(double));
        }
        public void Print()
        {
            Console.WriteLine("ФИО: {0}. Номер счета: {1}. Баланс счета: {2} руб. ", Name, Number, Balance);
        }
    }
}
