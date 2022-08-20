using System;
using System.Globalization;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            ContractService contractService = new ContractService(new PaypalService());

            contractService.processContract(contract, numberInstallments);
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
            /*
               int number = 8028;
               DateTime date = new DateTime(2018, 05, 28);
               double contractValue = 600.00;
               int numberInstallments = 3;
               Contract contract = new Contract(number, date, contractValue);
               ContractService contractService = new ContractService(new PaypalService());

               contractService.processContract(contract, numberInstallments);
               Console.WriteLine("Installments:");
               foreach (Installment installment in contract.Installments)
               {
                   Console.WriteLine(installment);
               }
           */
        }
    }
}
