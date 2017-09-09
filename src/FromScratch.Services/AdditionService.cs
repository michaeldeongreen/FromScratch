using FromScratch.Domain.Interfaces;
using FromScratch.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromScratch.Services
{
    public class AdditionService : IAdditionService
    {
        private readonly IUnitOfWork _uow;
        public AdditionService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public int Add(int number1, int number2)
        {
            int value = number1 + number2;
            return value;
        }
    }
}
