using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.Infrastructure.CloudService.Interfaces
{
    public interface IFileStorageService
    {
        void UploadFile(byte[] bytes, string fileName);
    }
}