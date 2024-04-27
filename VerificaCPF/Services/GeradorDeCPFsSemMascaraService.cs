using VerificaCPF.Models;

namespace VerificaCPF.Services;

public static class GeradorDeCPFsSemMascaraService
{
    public static IEnumerable<string> GeradorCpfsSemMascara(int qtde)
    {
        string cpf = "";
        List<string> cpfs = new List<string>();

        for (int i = 0; i < qtde; i++)
        {
            cpf = GeradorDeCPFServices.GeradorDeCPF();
            cpfs.Add(cpf);
        }

        return cpfs;
    }
}
