namespace VerificaCPF.Services;

public static class FormataCPFServices
{
    public static string FormataCPF(string cpf)
    {
        cpf = cpf.Replace(".","");
        cpf = cpf.Replace("-", "");

        return cpf;
    }
}
