Random rnd = new Random();
string cpf = "";
for (int i = 0; i < 9; i++)
{
    cpf += rnd.Next(0, 9).ToString();
}
    

int soma = 0;
for (int i = 0; i < 9; i++)
{
    soma += int.Parse(cpf[i].ToString()) * (10 - i);
}

int resto = soma % 11;
cpf += resto < 2 ? "0" : (11 - resto).ToString();

soma = 0;
for (int i = 0; i < 10; i++)
{
    soma += int.Parse(cpf[i].ToString()) * (11 - i);
}

resto = soma % 11;
cpf += resto < 2 ? "0" : (11 - resto).ToString();

Console.WriteLine(cpf);
Console.ReadKey();

