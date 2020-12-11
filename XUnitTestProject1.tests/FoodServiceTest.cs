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
    public class FoodServiceTest
    {
        [Fact]
        public async Task GetFoodsTest()
        {
            var foods = new List<Food>
            {
                new Food() { FoodID = 1},
                new Food() { Title = "Pizza" },
            };

            var fakeRepositoryMock = new Mock<IFoodRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(foods);


            var foodService = new FoodService(fakeRepositoryMock.Object);

            var resultFoods = await foodService.GetFoods();

            Assert.Collection(resultFoods, food =>
            {
                Assert.Equal(1, food.FoodID);
            },
            food =>
            {
                Assert.Equal("Pizza", food.Title);
            });
        }
    }
}
