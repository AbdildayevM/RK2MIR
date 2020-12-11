using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;

namespace RK2MIR.Repositories
{
    public interface IFoodRepository
    {
        Task<List<Food>> GetAll();
    }
}
