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
    public class EmployeeServiceTest
    {
        [Fact]
        public async Task GetEmployeesTest()
        {
            var employees = new List<Employee>
            {
                new Employee() { ID = 1 },
                new Employee() { FirstName = "K" },
            };

            var fakeRepositoryMock = new Mock<IEmployeeRepository>();
            fakeRepositoryMock.Setup(x => x.GetAll()).ReturnsAsync(employees);


            var employeeService = new EmployeeService(fakeRepositoryMock.Object);

            var resultEmployees = await employeeService.GetEmployees();

            Assert.Collection(resultEmployees, employee =>
            {
                Assert.Equal(1, employee.ID);
            },
            employee =>
            {
                Assert.Equal("K", employee.FirstName);
            });
        }
    }
}
