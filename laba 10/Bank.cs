using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Security.Cryptography;

namespace laba_10
{
    public enum AccType { current, saving }
    public class Bank
    {
        public static Hashtable ht = new Hashtable();
        static Bank()
        {
            ht = new Hashtable();
        }
        public static void CreateAccount()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.ID();
            ht.Add(SHA256.Create(), bankAccount);
        }
        public static void CreateAccount(decimal balance)
        {
            BankAccount bankAccount = new BankAccount(balance);
            ht.Add(SHA256.Create(), bankAccount);
            bankAccount.ID();
        }
        public static void CreateAccount(Type accountType)
        {
            BankAccount bankAccount = new BankAccount(accountType);
            ht.Add(SHA256.Create(), bankAccount);
            bankAccount.ID();
        }
        public static void CreateAccount(decimal balance, Type accountType)
        {
            BankAccount bankAccount = new BankAccount(balance, accountType);
            ht.Add(SHA256.Create(), bankAccount);
            bankAccount.ID();
        }
        public static void CloseAccount(long id)
        {
            ht.Remove(id);
        }
    }
}
