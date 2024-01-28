using Microsoft.AspNetCore.Mvc;
using PracticoSI1.Models;
using PracticoSI1.Service.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticoSI1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class clInsumoController
    {
        private readonly IclInsumoService _IclInsumoService;

        public clInsumoController(IclInsumoService iTemp)
        {
            this._IclInsumoService = iTemp;
        }

        [HttpGet]
        public async Task<List<clInsumo>> GetList()
        {
            return await _IclInsumoService.GetList();
        }

        [HttpPost("AgregaActualiza")]
        public async Task<clInsumo> AgregaActualiza(clInsumo l, string t)
        {
            return await _IclInsumoService.AgregaActualiza(l, t);
        }

        [HttpDelete("Eliminar")]
        public async Task<int> Eliminar(clInsumo l)
        {
            // Llama al método en el servicio para realizar la eliminación
            return await _IclInsumoService.Elimina(l);
        }
    }

}
