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
    public class ClientServiceTest
    {
        [Fact]
        public async Task GetClientsTest()
        {
            var clients = new List<Client>
            {
                new Client() { ID = 1, LastName = "Aa", FirstName = "A", Password = "qwerty", PhoneNumber = 87477477474, SignDate = new DateTime(2020, 12, 12) },
                new Client() { FirstName = "F" },
            };

            var fakeRepositoryMock = new Mock<IClientRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(clients);


            var clientService = new ClientService(fakeRepositoryMock.Object);

            var resultClients = await clientService.GetClients();

            Assert.Collection(resultClients, client =>
            {
                Assert.Equal(1, client.ID);
            },
            client =>
            {
                Assert.Equal("F", client.FirstName);
            });
        }
    }
}
