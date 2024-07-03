using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMarc.Api.Model;

namespace BookMarc.Api.Services
{
    public interface IKafkaConsumerService
    {
         NiceLabel GetTootInformation(string tootId);
    }
}