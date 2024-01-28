using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PracticoSI1.Models;
using PracticoSI1.Service.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class cIGrupoArticuloController
    {
        private readonly IcIGrupoArticuloService _IcIGrupoArticuloService;

        public cIGrupoArticuloController(IcIGrupoArticuloService iTemp)
        {
            this._IcIGrupoArticuloService = iTemp;
        }

        [HttpGet]
        [Authorize]
        public async Task<List<cIGrupoArticulo>> GetList()
        {
            return await _IcIGrupoArticuloService.GetList();
        }

        [HttpPost("AgregaActualiza")]
        public async Task<cIGrupoArticulo> AgregaActualiza(cIGrupoArticulo l, string t)
        {
            return await _IcIGrupoArticuloService.AgregaActualiza(l, t);
        }

        [HttpDelete("Eliminar")]
        public async Task<int> Eliminar(cIGrupoArticulo l)
        {
            // Llama al método en el servicio para realizar la eliminación
            return await _IcIGrupoArticuloService.Elimina(l);
        }
    }

}
