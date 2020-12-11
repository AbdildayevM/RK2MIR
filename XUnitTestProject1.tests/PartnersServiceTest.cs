using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using RK2MIR.Models;
using RK2MIR.Services;
using RK2MIR.Repositories;
using System.Threading.Tasks;
using Moq;

namespace XUnitTestProject1.tests
{
    public class PartnersServiceTest
    {
        [Fact]
        public async Task GetClientsTest()
        {
            var partners = new List<Partners>
            {
                new Partners() { PartnerID = 1 },
                new Partners() { CompanyName = "JJJ" },
            };

            var fakeRepositoryMock = new Mock<IPartnersRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(partners);


            var partnersService = new PartnersService(fakeRepositoryMock.Object);

            var resultPartners = await partnersService.GetPartners();

            Assert.Collection(resultPartners, partners =>
            {
                Assert.Equal(1, partners.PartnerID);
            },
            partners =>
            {
                Assert.Equal("JJJ", partners.CompanyName);
            });
        }
    }
}
