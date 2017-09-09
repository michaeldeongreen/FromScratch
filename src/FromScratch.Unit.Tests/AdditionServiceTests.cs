using FromScratch.Domain.Interfaces;
using FromScratch.Services;
using FromScratch.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FromScratch.Domain.Entities;

namespace FromScratch.Unit.Tests
{
    [TestFixture]
    public class AdditionServiceTests
    {
        [Test]
        public void Can_Add_Two_Numbers_Test()
        {
            //given
            int num1 = 1, num2 = 4;
            var uowMock = new Mock<IUnitOfWork>();
            uowMock.Setup(u => u.CompanyRepository.GetAll()).Returns(It.IsAny<IQueryable<Company>>);
            IAdditionService service = new AdditionService(uowMock.Object);
            //when
            int value = service.Add(num1, num2);
            //then
            value.Should().Be(5);
        }
    }
}
