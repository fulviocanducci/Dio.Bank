using Dio.Bank.Enums;
using Dio.Bank.Models;

namespace Dio.Bank
{
   internal class Program
   {
      static void Main(string[] args)
      {
         Account myAccount = new(TypeAccount.PhysicalPerson, "Fúlvio", 1000, 10000);
         
         Console.WriteLine(myAccount);
      }
   }
}