using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Repositories;

namespace RK2MIR.Services
{
    public class FoodService
    {
        private readonly IFoodRepository _foodRepo;

        public FoodService(IFoodRepository foodRepo)
        {
            _foodRepo = foodRepo;
        }

        public async Task<List<Food>> GetFoods()
        {
            return await _foodRepo.GetAll();
        }
    }
}
