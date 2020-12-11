using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using  RK2MIR.Models;


namespace XUnitTestProject1.tests.Models
{
    public class ConstructorsTests
    {
        [Fact]
        public void testCartConstructor()
        {
            Client c = new Client(1, "L", "F", 84744748888, "asfasrf",  new  DateTime(2020, 1, 1));
            Employee e = new Employee(1, "LL", "FF", 86846844554, "afcasdcf", 1);
            Food f = new Food(1, "Pizza", 545);
            News n = new News(1, "New Pizza", "adjfvbakjdf vaj vajnfd vajhdf vakhfdbvafjvkasnf vk ");
            Order o = new Order(1, 1, 1, "Manasa 5", 4, 2180, new DateTime(2020, 1, 1));
            Partners p = new Partners(1, "Pazzini", "Delicious", "afvadfvadfvadf");

        }
    }
}
