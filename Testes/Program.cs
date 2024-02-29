Console.Write("Digite o cpf, somente números: ");
string cpf = Console.ReadLine();

string subCpf = cpf.Substring(0, 9);
char[] subCpfChar = subCpf.ToCharArray();
int somaDigito = 0;
int indice = 0;
const int tamanhoCpf = 11;

for (int i = 10; i >= 2; i--)
{
    int digito = subCpfChar[indice] - '0';
    somaDigito += digito * i;
    indice++;
}

// Console.WriteLine("Soma digito 1: " + somaDigito1);
int resto = somaDigito % tamanhoCpf;
int digitoVerificador1 = 0;

if (resto >= 2)
{
    digitoVerificador1 = tamanhoCpf - resto;
}

// Console.WriteLine("O primeiro digito verificador é: {0}",digitoVerificador1);

// Calculando o segundo dígito
char[] novoSubCpf = new char[10];
subCpfChar.CopyTo(novoSubCpf, 0);
novoSubCpf[novoSubCpf.Length - 1] = digitoVerificador1.ToString()[0];
somaDigito = 0;
indice = 0;

for (int i = 11; i >= 2; i--)
{
    int digito = novoSubCpf[indice] - '0';
    somaDigito += digito * i;
    indice++;

}

resto = 0;
int digitoVerificador2 = 0;
resto = somaDigito % tamanhoCpf;
if (resto >= 2)
{
    digitoVerificador2 = tamanhoCpf - resto;
}

// Console.WriteLine($"O segundo digito verificador é: {digitoVerificador2}");
char[] cpfCompleto = cpf.ToCharArray();
int digitoprimeiro = cpfCompleto[9] - '0';
int digitosegundo = cpfCompleto[10] - '0';

if (digitoprimeiro != digitoVerificador1 || digitosegundo != digitoVerificador2 || subCpf == "123456789")
{
    Console.WriteLine($"\n#### O CPF: {cpf} é inválido ###");
}
else
{
    Console.WriteLine($"\n### O CPF: {cpf} é válido ###");
}
Console.ReadLine();
