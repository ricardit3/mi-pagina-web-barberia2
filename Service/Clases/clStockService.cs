﻿using PracticoSI1.Business.Contracts;
using PracticoSI1.Models;
using PracticoSI1.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Services.Clases
{
    public class clStockService : IclStockService
    {
        private readonly IclStockRepository _IclStockRepository;
        public clStockService(IclStockRepository tempI)
        {
            _IclStockRepository = tempI;
        }
        public Task<List<clStock>> GetList()
        {
            return _IclStockRepository.GetList();
        }
        public Task<clStock> AgregaActualiza(clStock l, string t)
        {
            return _IclStockRepository.AgregaActualiza(l, t);
        }

    }
}
