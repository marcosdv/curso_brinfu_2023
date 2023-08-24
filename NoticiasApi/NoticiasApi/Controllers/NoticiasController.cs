using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NoticiasApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NoticiasController : ControllerBase
{
    [HttpGet("Ola")]
    public string BuscarTodas()
    {
        return "Relou Uordi!!!";
    }
}
