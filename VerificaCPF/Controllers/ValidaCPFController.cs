using Microsoft.AspNetCore.Mvc;
using VerificaCPF.Models;

namespace VerificaCPF.Controllers;

[ApiController]
public class ValidaCPFController : Controller
{
    
    [HttpGet("ValidacaoCPF")]
    public IActionResult ValidacaoCPF (string cpf)
    {
        bool valido = ValidaCPF.cpfIsValido(cpf);
        if (valido)
        {
            return Ok($"O CPF {cpf} é válido");
        }
        return BadRequest($"O CPF {cpf} é inválido");
    }
}
