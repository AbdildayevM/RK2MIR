using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Data;
using Microsoft.EntityFrameworkCore;

namespace RK2MIR.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        readonly RK2MIRContext _context;

        public OrderRepository(RK2MIRContext context)
        {
            _context = context;
        }

        public Task<List<Order>> GetAll()
        {
            return _context.Order.ToListAsync();
        }
    }
}
