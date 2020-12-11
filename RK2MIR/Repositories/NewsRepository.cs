using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Data;
using Microsoft.EntityFrameworkCore;

namespace RK2MIR.Repositories
{
    public class NewsRepository : INewsRepository
    {
        readonly RK2MIRContext _context;

        public NewsRepository(RK2MIRContext context)
        {
            _context = context;
        }

        public Task<List<News>> GetAll()
        {
            return _context.News.ToListAsync();
        }
    }
}
