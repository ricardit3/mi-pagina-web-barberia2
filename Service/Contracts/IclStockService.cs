using PracticoSI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Services.Contracts
{
    public interface IclStockService
    {
        Task<List<clStock>> GetList();
        Task<clStock> AgregaActualiza(clStock l, string t);

    }
}
