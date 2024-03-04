//Random rnd = new Random();
//string cpf = "";
//for (int i = 0; i < 9; i++)
//{
//    cpf += rnd.Next(0, 9).ToString();
//}


//int soma = 0;
//for (int i = 0; i < 9; i++)
//{
//    soma += int.Parse(cpf[i].ToString()) * (10 - i);
//}

//int resto = soma % 11;
//cpf += resto < 2 ? "0" : (11 - resto).ToString();

//soma = 0;
//for (int i = 0; i < 10; i++)
//{
//    soma += int.Parse(cpf[i].ToString()) * (11 - i);
//}

//resto = soma % 11;
//cpf += resto < 2 ? "0" : (11 - resto).ToString();

//Console.WriteLine(cpf);

Console.Write("Digite um cpf ex: xxx.xxx.xxx-xx: ");
string cpf = Console.ReadLine();

Console.WriteLine($"\nTamanho do cpf antes: {cpf.Length}\n");

cpf = cpf.Replace(".", "");
cpf = cpf.Replace("-","");

Console.WriteLine($"\nTamanho do cpf depois: {cpf.Length}\n");

Console.WriteLine($"CPF após a formatação: {cpf}");

Console.ReadKey();

