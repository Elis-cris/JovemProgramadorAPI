using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Domain;

namespace JovemProgramadorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        public AlunoController()
        {
                
        }

        [HttpGet("BuscarDadosAluno/{Id}")]

        public async Task<IActionResult> BuscarDadosAlunos(int Id)
        {
            try
            {
                Aluno aluno = new Aluno();

                aluno.Id = Id;
                aluno.Nome = "Francisco";
                aluno.Matricula = "ABC123";

                return Ok(aluno);

            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }

        }

    }
}
