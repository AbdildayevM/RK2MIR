using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Repositories;

namespace RK2MIR.Services
{
    public class OrderService
    {
        private readonly IOrderRepository _orderRepo;

        public OrderService(IOrderRepository orderRepo)
        {
            _orderRepo = orderRepo;
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _orderRepo.GetAll();
        }
    }
}
