using PracticoSI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Business.Contracts
{
    public interface IclInsumoRepository
    {
        Task<List<clInsumo>> GetList();
        Task<int> Elimina(clInsumo l);
        Task<clInsumo> AgregaActualiza(clInsumo l, string t);
    }
}
