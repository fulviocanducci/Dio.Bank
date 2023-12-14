using Dio.Bank.Enums;
namespace Dio.Bank.Models
{
   public class Account
   {
      public Account() { }

      public Account(TypeAccount typeAccount, string name, decimal balance, decimal credit)
      {
         TypeAccount = typeAccount;
         Name = name;
         Balance = balance;
         Credit = credit;
      }

      public TypeAccount TypeAccount { get; set; }
      public string Name { get; set; } = string.Empty;
      public decimal Balance { get; set; }
      public decimal Credit { get; set; }

      public bool WithdrawMoney(decimal value)
      {
         if (Balance - value < (Credit * -1))
         {
            return false;
         }
         else
         {
            Balance -= value;
         }
         return true;
      }
      
      public bool CashDeposit(decimal value)
      {
         Balance += value;
         return true;
      }

      public bool BankTransfer(decimal value, Account account)
      {
         if (WithdrawMoney(value))
         {
            account.CashDeposit(value);
            return true;
         }
         return false;
      }

      public static Account Create(TypeAccount typeAccount, string name, decimal balance, decimal credit)
      {
         return new(typeAccount, name, balance, credit);
      }

      public override string ToString()
      {
         return $"Tipo Conta: {TypeAccount}\r\nNome:{Name}\r\nSaldo: {Balance}\r\nCredito: {Credit}\r\n";
      } 
   }
}
