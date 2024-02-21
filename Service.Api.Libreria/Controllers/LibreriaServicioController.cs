using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Api.Libreria.Repository;
using Servicios.Api.Libreria.Core.Entities;

namespace Service.Api.Libreria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibreriaServicioController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;

        public LibreriaServicioController(IAutorRepository autorRepository)
        {
            this._autorRepository = autorRepository;
        }

        /// <summary>
        /// Método que trae la lista de todos los autores
        /// </summary>
        /// <returns></returns>
        [HttpGet("obtener-autores")]
        public async Task<ActionResult<IEnumerable<Autor>>> ObtenerAutores() 
        {
            var autores = await _autorRepository.GetAutores();

            if (autores is null)
            {
                return BadRequest();
            }

            return Ok(autores);
        }
    }
}
