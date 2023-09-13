using System.Text;
using System.Text.Json;
using DevFreela.Core.DTOs;
using DevFreela.Core.Services;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Infrastructure.CloudService.Implementations
{
    public class PaymentsService : IPaymentsService
    {
        private readonly IMessageBusSerice _messageBusSerice;
        private const string QUEUE_NAME = "Payments";

        public PaymentsService(IMessageBusSerice messageBusSerice)
        {
            _messageBusSerice = messageBusSerice;
        }
        public void ProcessPayment(PaymentInfoDTO paymentInfoDTO)
        {
            var paymentInfoJson = JsonSerializer.Serialize(paymentInfoDTO);

            var paymentInfoBytes = Encoding.UTF8.GetBytes(paymentInfoJson);

            _messageBusSerice.Publish(QUEUE_NAME, paymentInfoBytes);


        }
    }
}