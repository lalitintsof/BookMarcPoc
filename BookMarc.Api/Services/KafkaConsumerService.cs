using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMarc.Api.Model;

namespace BookMarc.Api.Services
{
    public class KafkaConsumerService : IKafkaConsumerService
    {
        private readonly NiceLabel _niceLabel;
        public KafkaConsumerService(){
            _niceLabel=new NiceLabel(){
                FirstName="test",
                LastName="test",   
                Id=1,
                isActive=true
            };
        }
        public NiceLabel GetTootInformation(string tootId)
        {
           return _niceLabel;
        }
    }
}