using Dio.Bank.Enums;
using Dio.Bank.Models;
using System.Net.Http.Headers;

namespace Dio.Bank
{
   internal class Program
   {
      static List<Account> Accounts = new();
      static int MenuId = -1;
      static void Menu()
      {
         Console.WriteLine("1 - Cadastrar Conta");
         Console.WriteLine("2 - Remover Conta");
         Console.WriteLine("3 - Lista Contas");
         Console.WriteLine("4 - Pesquisa Conta");
         Console.WriteLine("0 - Sair");
         Console.Write("Digite a opção: ");
      }

      static void NewAccount()
      {
         Account account = new Account
         {
            Name = Console.ReadLine(),
            TypeAccount = Console.ReadLine()?.ToString() == "1" ? TypeAccount.LegalPerson : TypeAccount.PhysicalPerson,
            Balance = decimal.Parse(Console.ReadLine().ToString()),
            Credit = decimal.Parse(Console.ReadLine().ToString())
         };
         Accounts.Add(account);
      }

      static void DeleteAccount()
      {

      }

      static void ListAccount()
      {
         Accounts.ForEach(x => Console.WriteLine(x));
      }

      static void FindAccount()
      {

      }

      static void MenuCall()
      {
         switch(MenuId)
         {
            case 0:
               {
                  break;
               }
            case 1:
               {
                  NewAccount();
                  break;
               }
            case 2:
               {
                  DeleteAccount();
                  break;
               }
            case 3:
               {
                  ListAccount();
                  break;
               }
            case 4:
               {
                  FindAccount();
                  break;
               }
         }
      }

      static void Main(string[] args)
      {
         while (MenuId != 0)
         {
            Menu();
            if (!int.TryParse(Console.ReadLine(), out MenuId))
            {
               MenuId = -1;
            }
            MenuCall();
         }
      }
   }
}