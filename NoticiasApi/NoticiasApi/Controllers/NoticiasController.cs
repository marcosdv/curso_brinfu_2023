using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NoticiasApi.Models;
using NoticiasApi.Repositories;

namespace NoticiasApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NoticiasController : ControllerBase
{
    [HttpGet("Ola")]
    public string Ola()
    {
        return "Relou Uordi!!!";
    }

    [HttpGet]
    public IActionResult BuscarTodas()
    {
        var repository = new NoticiasRepository();
        var dados = repository.BuscarTodas();

        if (dados.ToList().Count > 0)
            return Ok(dados);

        return NoContent();
    }

    [HttpPost]
    public IActionResult Adicionar(Noticia noticia)
    {
        try
        {
            var repository = new NoticiasRepository();
            return Ok(repository.Adicionar(noticia));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
