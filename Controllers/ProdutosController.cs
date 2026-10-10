using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProdutosApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        ///<summary> Servico para cadastro de produto na API.</summary>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
        }

        ///<summary>Servico para atualizacao de produto na API.</summary>
        [HttpPut]
        public IActionResult Put() 
        { 
            return Ok();
        }

        ///<summary>Servico para exclusao de produto na API.</summary>
        [HttpDelete]
        public IActionResult Delete() 
        { 
            return Ok();
        }

        ///<summary>Servico para consulta de produtos na API.</summary>
        [HttpGet]
        public IActionResult Get()
        { 
            return Ok();
        }

    }
}
