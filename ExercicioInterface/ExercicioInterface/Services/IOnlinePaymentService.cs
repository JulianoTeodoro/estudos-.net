using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Services
{
    interface IOnlinePaymentService
    {
        public double paymentFee(double amount);
        public double interest(double amount, int months);

    }
}
