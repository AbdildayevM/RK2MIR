using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Repositories;

namespace RK2MIR.Services
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeRepo.GetAll();
        }
    }
}
