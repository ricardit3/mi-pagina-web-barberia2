using PracticoSI1.Business.Contracts;
using PracticoSI1.Models;
using PracticoSI1.Service.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Service.Clases
{
    public class cIGrupoArticuloService : IcIGrupoArticuloService
    {
        private readonly IcIGrupoArticuloRepository _IcIGrupoArticuloRepository;

        public cIGrupoArticuloService(IcIGrupoArticuloRepository tempI)
        {
            _IcIGrupoArticuloRepository = tempI;
        }

        public Task<List<cIGrupoArticulo>> GetList()
        {
            return _IcIGrupoArticuloRepository.GetList();
        }

        public Task<cIGrupoArticulo> AgregaActualiza(cIGrupoArticulo l, string t)
        {
            return _IcIGrupoArticuloRepository.AgregaActualiza(l, t);
        }

        public Task<int> Elimina(cIGrupoArticulo l)
        {
            return _IcIGrupoArticuloRepository.Elimina(l);
        }
    }

}
