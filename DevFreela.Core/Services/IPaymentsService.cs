using DevFreela.Core.DTOs;

namespace DevFreela.Core.Services
{
    public interface IPaymentsService
    {
        void ProcessPayment(PaymentInfoDTO paymentInfoDTO);


    }
}