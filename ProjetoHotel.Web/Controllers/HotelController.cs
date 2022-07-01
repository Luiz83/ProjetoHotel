using Microsoft.AspNetCore.Mvc;
using ProjetoHotel.Lib.Data.Repositorios.Interfaces;

namespace ProjetoHotel.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class HotelController : ControllerBase
    {
        private readonly IRepositorioHotel _repositorio;

        public HotelController(IRepositorioHotel repositorio)
    {
        _repositorio = repositorio;
    }

    [HttpGet("BuscarTodos")]
    public IActionResult BuscarTodos()
    {
        return Ok(_repositorio.BuscarTodos());
    }
    
    }
}