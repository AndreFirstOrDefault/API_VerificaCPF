using Microsoft.AspNetCore.Mvc;
using VerificaCPF.Controllers;

namespace API_VerificaCPF_Teste;

[TestClass]
public class ValidaCPFTest
{
    private ValidaCPFController _controller;

    // Retorna Sucesso
    [TestMethod]
    public void ValidaCPFSemMascara_Sucess_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();
        
        // Act
        var response = _controller.ValidacaoCPF("94792235030");

        // Assert
        Assert.IsInstanceOfType(response, typeof(OkObjectResult));
    }

    // Falha cpf inválido
    [TestMethod]
    public void ValidaCPFSemMascara_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPF("12345678910");

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));
    }

    // Falha - menos de 11 caracteres
    [TestMethod]
    public void ValidaCPFSemMascaraMenosDe11Caracteres_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPF("9479223503");

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));
    }

    // Falha - contém letra
    [TestMethod]
    public void ValidaCPFSemMascaraComLetra_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPF("94k92235030");

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));
    }

    // Retorna Sucesso
    [TestMethod]
    public void ValidaCPFComMascara_Sucess_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPFCompleto("129.468.420-53");

        // Assert
        Assert.IsInstanceOfType(response, typeof(OkObjectResult));
    }

    // Falha cpf inválido
    [TestMethod]
    public void ValidaCPFComMascara_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPFCompleto("873.111.680-70");

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));
    }

    // Falha - menos de 14 caracteres
    [TestMethod]
    public void ValidaCPFComMascaraMenosDe14Caracteres_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPFCompleto("873.111.680-7");

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));
    }

    // Falha - contém letra
    [TestMethod]
    public void ValidaCPFComMascaraComLetra_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.ValidacaoCPFCompleto("873.11x.680-70");

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));
    }

    // Sucesso - Gerador de CPF sem mascara
    [TestMethod]
    public void GeraCPFSemMascara_Sucess_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.GeradorCPF();

        // Assert
        Assert.IsInstanceOfType(response, typeof(OkObjectResult));
    }

    // Sucesso - Gerador de CPF com mascara
    [TestMethod]
    public void GeraCPFComMascara_Sucess_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.GeradorCPFMascara();

        // Assert
        Assert.IsInstanceOfType(response, typeof(OkObjectResult));
    }

    // Sucesso - Valida Cpf com ou sem mascara (automatico)
    [TestMethod]
    public void ValidaCPFAutomatico_Sucess()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response1 = _controller.ValidarCPFAutomatico("82775899056");
        var response2 = _controller.ValidarCPFAutomatico("709.018.410-21");

        // Assert
        Assert.IsInstanceOfType(response1, typeof(OkObjectResult));
        Assert.IsInstanceOfType(response2, typeof(OkObjectResult));

    }

    // Falha - Valida Cpf com ou sem mascara (automatico)
    [TestMethod]
    public void ValidaCPFAutomatico_Failed()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response1 = _controller.ValidarCPFAutomatico("82775894446");
        var response2 = _controller.ValidarCPFAutomatico("709.018.000-21");

        // Assert
        Assert.IsInstanceOfType(response1, typeof(BadRequestObjectResult));
        Assert.IsInstanceOfType(response2, typeof(BadRequestObjectResult));

    }

    // Sucesso - Gerador de CPFs sem mascara
    [TestMethod]
    public void GeraCPFsSemMascara_Sucess_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.GeradorDeCpfsComMascara(10).Result;
        
        // Assert
        Assert.IsInstanceOfType(response, typeof(OkObjectResult));
        
    }

    // Falha - Gerador de CPFs sem mascara
    [TestMethod]
    public void GeraCPFsSemMascara_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.GeradorDeCpfsComMascara(1).Result;

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));

    }

    // Sucesso - Gerador de CPFs com mascara
    [TestMethod]
    public void GeraCPFsComMascara_Sucess_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.GeradorDeCpfsComMascara(10).Result;
        
        // Assert
        Assert.IsInstanceOfType(response, typeof(OkObjectResult));
       
    }

    // Falha - Gerador de CPFs com mascara
    [TestMethod]
    public void GeraCPFsComMascara_Failed_Test()
    {
        // Arrange
        _controller = new ValidaCPFController();

        // Act
        var response = _controller.GeradorDeCpfsComMascara(0).Result;

        // Assert
        Assert.IsInstanceOfType(response, typeof(BadRequestObjectResult));

    }
}