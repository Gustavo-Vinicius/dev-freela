using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;
using DevFreela.Infrastructure.CloudService.Interfaces;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Infrastructure.CloudService.Implementations
{
    public class PaymentsService : IPaymentsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly string _paymentsBaseUrl;

        public PaymentsService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _paymentsBaseUrl = configuration.GetSection("Services:Payments").Value;
        }
        public async Task<bool> ProcessPayment(PaymentInfoDTO paymentInfoDTO)
        {

            var url = $"{_paymentsBaseUrl}/api/payments";
            var paymentInfoJson = JsonSerializer.Serialize(paymentInfoDTO);

            var paymentInfoContent = new StringContent(
                paymentInfoJson,
                Encoding.UTF8,
                "application/json"
            );

            var httpClient = _httpClientFactory.CreateClient("Payments");

            var response = await httpClient.PostAsync(url, paymentInfoContent);

            return response.IsSuccessStatusCode;
        }
    }
}