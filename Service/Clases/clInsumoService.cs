using PracticoSI1.Business.Contracts;
using PracticoSI1.Models;
using PracticoSI1.Service.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Service.Clases
{
    public class clInsumoService : IclInsumoService
    {
        private readonly IclInsumoRepository _IclInsumoRepository;

        public clInsumoService(IclInsumoRepository tempI)
        {
            _IclInsumoRepository = tempI;
        }

        public Task<List<clInsumo>> GetList()
        {
            return _IclInsumoRepository.GetList();
        }

        public Task<int> Elimina(clInsumo l)
        {
            return _IclInsumoRepository.Elimina(l);
        }

        public Task<clInsumo> AgregaActualiza(clInsumo l, string t)
        {
            return _IclInsumoRepository.AgregaActualiza(l, t);
        }
    }

}
