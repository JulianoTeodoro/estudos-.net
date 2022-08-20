using System;
using System.Collections.Generic;
using System.Text;
using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    class ContractService
    {
        private readonly IOnlinePaymentService onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this.onlinePaymentService = onlinePaymentService;
        }

        public void processContract(Contract contract, int months)
        {
            double totalQuota = contract.totalValue / months;

            for(int i = 1; i <= months; i++)
            {
                DateTime dueDate = contract.date.AddMonths(i);
                double paymentFee = totalQuota + onlinePaymentService.paymentFee(totalQuota);
                double interest = paymentFee + onlinePaymentService.interest(paymentFee, i);

                contract.addInstallment(new Installment(dueDate, interest));
            }
        }
    }
}
