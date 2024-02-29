using Microsoft.AspNetCore.Mvc;
using VerificaCPF.Validations;

namespace VerificaCPF.Controllers;

[ApiController]
public class ValidaCPFController : ControllerBase
{
    
    [HttpGet("ValidacaoCPF")]
    public IActionResult ValidacaoCPF (string cpf)
    {
        if(cpf == null || cpf.Length != 11)
        {
            return BadRequest("O CPF deve conter 11 numeros!");
        }

        var validator2 = new VerificaCaracteresAttribute();
        var resdult2 = validator2.IsValid(cpf);

        if(resdult2 == false)
        {
            return BadRequest("O CPF deve conter somente numeros!");
        }

        var validator = new VerificaDigitosAttribute();
        var result = validator.IsValid(cpf);

        if(result)
        {
            return Ok("CPF válido.");
        }

        return BadRequest("CPF inválido.");

    }
}
