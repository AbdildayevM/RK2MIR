using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Data;
using Microsoft.EntityFrameworkCore;

namespace RK2MIR.Repositories
{
    public class PartnersRepository : IPartnersRepository
    {
        readonly RK2MIRContext _context;

        public PartnersRepository(RK2MIRContext context)
        {
            _context = context;
        }

        public Task<List<Partners>> GetAll()
        {
            return _context.Partners.ToListAsync();
        }
    }
}
