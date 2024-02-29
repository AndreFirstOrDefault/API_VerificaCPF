using Microsoft.AspNetCore.Mvc;
using VerificaCPF.Validations;

namespace VerificaCPF.Controllers;

[ApiController]
public class ValidaCPFController : ControllerBase
{
    
    [HttpGet("ValidacaoCPF")]
    public IActionResult ValidacaoCPF (string cpf)
    {
        var validator = new VerificaDigitosAttribute();
        var result = validator.IsValid(cpf);

        if(result)
        {
            return Ok("CPF válido.");
        }

        return BadRequest("CPF inválido.");

    }
}
