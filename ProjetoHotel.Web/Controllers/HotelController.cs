using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using ProjetoHotel.Lib.Data.Repositorios.Interfaces;
using ProjetoHotel.Lib.Models;
using ProjetoHotel.Web.DTOs;
using ProjetoHotel.Web.DTOs.RespostaHTTP;

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
                                      hotelDto.Telefone, hotelDto.Email, TimeOnly.Parse(hotelDto.HorarioCheckIn.ToString("t")), TimeOnly.Parse(hotelDto.HorarioCheckOut.ToString("t")),
                                      hotelDto.DataCadastro, hotelDto.DataUltimaAtualizacao);
            _repositorio.Adicionar(novoHotel);
            return Ok("Hotel adicionado com sucesso!");
        }
        [HttpPost("AdicionarAsync")]
        public async Task<IActionResult> AdicionarHotelAsync(HotelDTO hotelDto)
        {
            var endereco = await BuscarEnderecoPeloViaCep(hotelDto.Cep);
            var novoHotel = new Hotel(hotelDto.Id, hotelDto.Nome, endereco, hotelDto.Cep, hotelDto.Descricao,
                                      hotelDto.Telefone, hotelDto.Email, TimeOnly.Parse(hotelDto.HorarioCheckIn.ToString("t")), TimeOnly.Parse(hotelDto.HorarioCheckOut.ToString("t")),
                                      hotelDto.DataCadastro, hotelDto.DataUltimaAtualizacao);
            await _repositorio.AdicionarAsync(novoHotel);
            var conteudo = JsonContent.Create(new HotelDtoResquestHttp()
            {
                id = hotelDto.Id,
                nome = hotelDto.Nome,
                cep = hotelDto.Cep,
                descricao = hotelDto.Descricao,
                telefone = hotelDto.Telefone,
                email = hotelDto.Email,
                checkin = hotelDto.HorarioCheckIn,
                checkout = hotelDto.HorarioCheckOut
            });
            var response = await client.PostAsync("https://dodev-ex.herokuapp.com/Hotel/Estatico", conteudo);
            return Ok(await response.Content.ReadAsStringAsync());
        }
        [HttpDelete("Deletar")]
        public IActionResult Delete(int id)
        {
            _repositorio.Deletar(id);
            return Ok("Deletado com sucesso");
        }
        private async Task<string> BuscarEnderecoPeloViaCep(string cep)
        {
            var request = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");
            var BodyRequest = await request.Content.ReadAsStringAsync();
            var endereco = JsonSerializer.Deserialize<DeserializeCep>(BodyRequest);
            string retorno = endereco.logradouro;
            return retorno;
        }
    }
}