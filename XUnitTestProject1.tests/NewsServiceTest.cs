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
    public class NewsServiceTest
    {
        [Fact]
        public async Task NewsTest()
        {
            var news = new List<News>
            {
                new News() { NewsID = 1 },
                new News() { Title = "Ulala" },
            };

            var fakeRepositoryMock = new Mock<INewsRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(news);


            var newsService = new NewsService(fakeRepositoryMock.Object);

            var resultNews = await newsService.GetNews();

            Assert.Collection(resultNews, news =>
            {
                Assert.Equal(1, news.NewsID);
            },
            news =>
            {
                Assert.Equal("Ulala", news.Title);
            });
        }
    }
}
