using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;

namespace DevFreela.Infrastructure.CloudService.Interfaces
{
    public interface IPaymentsService
    {
        Task<bool>ProcessPayment(PaymentInfoDTO paymentInfoDTO);
    }
}