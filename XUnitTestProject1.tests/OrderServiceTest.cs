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
    public class OrderServiceTest
    {
        [Fact]
        public async Task GetOrdersTest()
        {
            var orders = new List<Order>
            {
                new Order() { ID = 1  },
                new Order() { Address = "Manas" },
            };

            var fakeRepositoryMock = new Mock<IOrderRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(orders);


            var orderService = new OrderService(fakeRepositoryMock.Object);

            var resultOrders = await orderService.GetOrders();

            Assert.Collection(resultOrders, order =>
            {
                Assert.Equal(1, order.ID);
            },
            order =>
            {
                Assert.Equal("Manas", order.Address);
            });
        }
    }
}
