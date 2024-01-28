using PracticoSI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Business.Contracts
{
    public interface IcIGrupoArticuloRepository
    {
        Task<List<cIGrupoArticulo>> GetList();
        Task<int> Elimina(cIGrupoArticulo l);
        Task<cIGrupoArticulo> AgregaActualiza(cIGrupoArticulo l, string t);
    }
}
