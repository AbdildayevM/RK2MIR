using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RK2MIR.Models;
using RK2MIR.Repositories;

namespace RK2MIR.Services
{
    public class NewsService
    {
        private readonly INewsRepository _newsRepo;

        public NewsService(INewsRepository newsRepo)
        {
            _newsRepo = newsRepo;
        }

        public async Task<List<News>> GetNews()
        {
            return await _newsRepo.GetAll();
        }
    }
}
