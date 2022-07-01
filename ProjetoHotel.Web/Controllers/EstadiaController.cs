using Microsoft.AspNetCore.Mvc;
using ProjetoHotel.Lib.Models;
using ProjetoHotel.Web.DTOs.RespostaHTTP;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ProjetoHotel.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EstadiaController : ControllerBase
    {

        static readonly HttpClient client = new HttpClient();

        [HttpGet("CEP")]
        public async Task<IActionResult> GetCEP(string cep)
        {
            var resposta = await client.GetAsync($"https://viacep.com.br/ws/{cep}/json/");

            resposta.EnsureSuccessStatusCode();

            var corpoResposta = await resposta.Content.ReadAsStringAsync();

            return Ok(corpoResposta);
        }
    }
}









