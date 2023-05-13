﻿// Exercise no. 2
using System;
using System.Numerics;

namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingAccount SA = new SavingAccount(12345657, 2000);
            SA.deposit(100);
            SA.withdrawal(50);

            Checkingaccount CA = new Checkingaccount(129875587, 3000);
            CA.deposit(50);
            CA.withdrawal(500);

        }
    }

    abstract class BankAccount
    {
        public BigInteger AccNo;
        public double balance;
        public abstract void deposit(double amount);
        public abstract void withdrawal(double amount);
    }

    class SavingAccount : BankAccount
    {
        double interestRate = 0;
        public SavingAccount(BigInteger Accountnumber, double Balance)
        {
            this.AccNo = Accountnumber;
            this.balance = Balance;
        }
        public override void deposit(double amount)
        {

            this.balance += amount;
            Console.WriteLine($"{amount}Rs was deposited to your account number {this.AccNo}, your current balance is {this.balance}");
        }

        public override void withdrawal(double amount)
        {

            this.balance -= amount;
            Console.WriteLine($"{amount}Rs was withdrew from your account number {this.AccNo}, your current balance is {this.balance}");
        }
    }
    class Checkingaccount : BankAccount
    {
        double odlimit = 0;
        public Checkingaccount(BigInteger Accountnumber, double Balance)
        {
            this.AccNo = Accountnumber;
            this.balance = Balance;
        }
        public override void deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine($"{amount}Rs was deposited to your account number {this.AccNo}, your current balance is {this.balance}");
        }

        public override void withdrawal(double amount)
        {
            this.balance -= amount;
            Console.WriteLine($"{amount}Rs was withdrew from your account number {this.AccNo}, your current balance is {this.balance}");
        }
    }
}