using Microsoft.AspNetCore.Mvc;
using VerificaCPF.Services;
using VerificaCPF.Validations;

namespace VerificaCPF.Controllers;

[ApiController]
public class ValidaCPFController : ControllerBase
{

    [HttpGet("ValidarCPF xxxxxxxxxxx")]
    public IActionResult ValidacaoCPF(string cpf)
    {
        if (!ContadorDeCaracteresServices.ContadorDeCaracteres(cpf, 11))
        {
            return BadRequest("O CPF deve conter 11 numeros!");
        }

        var validator2 = new VerificaCaracteresAttribute();
        var result2 = validator2.IsValid(cpf);

        if (result2 == false)
        {
            return BadRequest("O CPF deve conter somente numeros!");
        }

        var validator = new VerificaDigitosAttribute();
        var result = validator.IsValid(cpf);

        if (result)
        {
            return Ok("CPF válido.");
        }

        return BadRequest("CPF inválido.");

    }

    [HttpGet("ValidarCPF xxx.xxx.xxx-xx")]
    public IActionResult ValidacaoCPFCompleto(string cpf)
    {
        if (!ContadorDeCaracteresServices.ContadorDeCaracteres(cpf, 14))
        {
            return BadRequest("O CPF deve conter 14 caracteres!");
        }

        var validator = new VerificaCaracteresAttribute();
        var result = validator.IsValid(cpf);

        if (result == false)
        {
            return BadRequest("O CPF não deve conter letras!");
        }

        var cpfFormatado = FormataCPFServices.FormataCPF(cpf);

        var validator2 = new VerificaDigitosAttribute();
        var result2 = validator2.IsValid(cpfFormatado);

        if (result2)
        {
            return Ok("CPF válido");
        }

        return BadRequest("CPF inválido");
    }


    [HttpGet("GeradorCPF xxxxxxxxxxx")]
    public IActionResult GeradorCPF()
    {
        var cpf = GeradorDeCPFServices.GeradorDeCPF();
        return Ok($"CPF gerado: {cpf}");
    }

    [HttpGet("GeradorCPF xxx.xxx.xxx-xx")]
    public IActionResult GeradorCPFMascara()
    {
        var cpf = GeradorDeCPFServices.GeradorDeCPF();
        var cpfMascara = FormataCPFServices.FormataCPFMascara(cpf);
        return Ok($"CPF gerado: {cpfMascara}");
    }

    [HttpGet("ValidarCPF xxxxxxxxxxx ou xxx.xxx.xxx-xx ")]
    public IActionResult ValidarCPFAutomatico(string cpf)
    {
        if (ContadorDeCaracteresServices.ContadorDeCaracteres(cpf, 11))
        {
            var validator2 = new VerificaCaracteresAttribute();
            var result2 = validator2.IsValid(cpf);

            if (result2 == false)
            {
                return BadRequest("O CPF deve conter somente numeros!");
            }

            var validator = new VerificaDigitosAttribute();
            var result = validator.IsValid(cpf);

            if (result)
            {
                return Ok("CPF válido.");
            }

            return BadRequest("CPF inválido.");
        }

        if (ContadorDeCaracteresServices.ContadorDeCaracteres(cpf, 14))
        {
            var validator = new VerificaCaracteresAttribute();
            var result = validator.IsValid(cpf);

            if (result == false)
            {
                return BadRequest("O CPF não deve conter letras!");
            }

            var cpfFormatado = FormataCPFServices.FormataCPF(cpf);

            var validator2 = new VerificaDigitosAttribute();
            var result2 = validator2.IsValid(cpfFormatado);

            if (result2)
            {
                return Ok("CPF válido");
            }

            return BadRequest("CPF inválido");
        }

        return BadRequest("Ocorreu um erro desconhecido!");
    }

    [HttpGet("GeradorDeCPFs (xxxxxxxxxxx)/{quantidade}", Name = "GeradorDeCPFsSemMascara")]
    public ActionResult<IEnumerable<string>> GeradorDeCpfsSemMascara(int quantidade)
    {
        if(quantidade == 1)
        {
            return BadRequest("Para gerar apenas um cpf utilize outro método!");
        }
        if(quantidade < 1)
        {
            return BadRequest("Valor inteiro inválido!");
        }

        List<string> cpfs = new List<string>() ;
        cpfs = GeradorDeCPFsSemMascaraService.GeradorCpfsSemMascara(quantidade).ToList();
        return Ok(cpfs);
    }

    [HttpGet("GeradorDeCPFs (xxx.xxx.xxx-xx)/{quantidade}", Name = "GerarDeCPFsComMascara")]
    public ActionResult<IEnumerable<string>> GeradorDeCpfsComMascara(int quantidade)
    {
        if (quantidade == 1)
        {
            return BadRequest("Para gerar apenas um cpf utilize outro método!");
        }
        if (quantidade < 1)
        {
            return BadRequest("Valor inteiro inválido!");
        }

        List<string> cpfs = new List<string>();
        cpfs = GeradorDeCPFsSemMascaraService.GeradorCpfsSemMascara(quantidade).ToList();
        string cpfFormatado = "";
        List<string> cpfsFormatados = new List<string>();

        foreach (var cpf in cpfs)
        {
            cpfFormatado = FormataCPFServices.FormataCPFMascara(cpf);
            cpfsFormatados.Add(cpfFormatado);
        }

        return Ok(cpfsFormatados);
    }
}
