using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Data;
using Microsoft.EntityFrameworkCore;

namespace RK2MIR.Repositories
{
    public class ClientRepository : IClientRepository
    {

        readonly RK2MIRContext _context;

        public ClientRepository(RK2MIRContext context)
        {
            _context = context;
        }

        public Task<List<Client>> GetAll()
        {
            return _context.Client.ToListAsync();
        }
    }

}
