using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Core.Services
{
    public interface IMessageBusSerice
    {
        void Publish(string queue, byte[] message);
    }
}