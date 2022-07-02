using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ProjetoHotel.Lib.Data.Repositorios.Interfaces;
using ProjetoHotel.Lib.Models;
using ProjetoHotel.Web.DTOs;

namespace ProjetoHotel.Web.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class HotelController : ControllerBase
    {
        private readonly IRepositorioHotel _repositorio;
        static readonly HttpClient client = new HttpClient();

        public HotelController(IRepositorioHotel repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet("BuscarTodos")]
        public IActionResult BuscarTodos()
        {
            return Ok(_repositorio.BuscarTodos());
        }

        [HttpGet("BuscarTodosAsync")]
        public async Task<IActionResult> BuscarTodosAsync()
        {
            try
            {
                var todosHoteis = await _repositorio.BuscarTodosAsync();
                return Ok(todosHoteis);
            }
            catch (System.Exception ex)
            {
                var resposta = await client.GetAsync("https://dodev-ex.herokuapp.com/Hotel/estatico");
                var corpoResposta = await resposta.Content.ReadAsStringAsync();
                var listaDeHoteis = JsonSerializer.Deserialize<List<HotelDTO>>(corpoResposta);

                return Ok(listaDeHoteis);
                throw;
            }
        }
        [HttpPost("Adicionar")]
        public IActionResult AdicionarHotel(HotelDTO hotelDto)
        {
            var novoHotel = new Hotel(hotelDto.Id, hotelDto.Nome, hotelDto.Endereco, hotelDto.Cep, hotelDto.Descricao,
                                      hotelDto.Telefone, hotelDto.Email, hotelDto.HorarioCheckIn, hotelDto.HorarioCheckOut,
                                      hotelDto.DataCadastro, hotelDto.DataUltimaAtualizacao);
            _repositorio.Adicionar(novoHotel);                      
            return Ok("Hotel adicionado com sucesso!");
        }
        [HttpPost("AdicionarAsync")]
        public async Task<IActionResult> AdicionarHotelAsync(HotelDTO hotelDto)
        {
            var novoHotel = new Hotel(hotelDto.Id, hotelDto.Nome, hotelDto.Endereco, hotelDto.Cep, hotelDto.Descricao,
                                      hotelDto.Telefone, hotelDto.Email, hotelDto.HorarioCheckIn, hotelDto.HorarioCheckOut,
                                      hotelDto.DataCadastro, hotelDto.DataUltimaAtualizacao);
            await _repositorio.AdicionarAsync(novoHotel);                      
            return Ok("Hotel adicionado com sucesso!");
        }

    }
}