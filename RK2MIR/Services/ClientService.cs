using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RK2MIR.Controllers;
using RK2MIR.Models;
using RK2MIR.Data;
using Microsoft.EntityFrameworkCore;
using RK2MIR.Repositories;


//will write some examples as there are a lot of methods in my controllers
//Install-Package Moq -Version 4.15.2 skachal
namespace RK2MIR.Services
{
    public class ClientService
    {
        private readonly IClientRepository _clientRepo;

        public ClientService(IClientRepository clientRepo)
        {
            _clientRepo = clientRepo;
        }

        public async Task<List<Client>> GetClients()
        {
            return await _clientRepo.GetAll();
        }

       
    }
}
