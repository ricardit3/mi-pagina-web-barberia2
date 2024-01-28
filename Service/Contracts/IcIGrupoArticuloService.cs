using PracticoSI1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Service.Contracts
{
    public interface IcIGrupoArticuloService
    {
        Task<List<cIGrupoArticulo>> GetList();
        Task<cIGrupoArticulo> AgregaActualiza(cIGrupoArticulo l, string t);
        Task<int> Elimina(cIGrupoArticulo l);
    }
}
