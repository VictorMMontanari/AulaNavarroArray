
//string texto = "C# é ruim";
//Console.WriteLine(texto);

//string titulo = "Arquitetura" + " de " + "Software";
//Console.WriteLine(titulo);

//titulo += "!";
//Console.WriteLine(titulo);

//string nome = "Jão";
//int idade = 21;

//Console.WriteLine("Olá {0}, sua idade é: {1}", nome, idade);
//Console.WriteLine("Olá {0}, sua nova idade é: {1}", nome, idade);

//string texto = "Rua abc, 35, Marília, São Paulo";
//string[] vetorTexto = texto.Split(',');

//for (int i = 0; i < vetorTexto.Length; i++)
//{
//    Console.WriteLine(vetorTexto[i]);
//}

//int[] numeros = new int[10];
//string[] nomes = new string[] {"nome1","nome2"};

//Console.WriteLine(numeros[1]);
//Console.WriteLine(nomes[0]);

//string conteudo = "16,23,34,24,15,25,35,35,54,32";
//string[] idades = conteudo.Split(',');

//int soma = 0;
//foreach (var n in idades)
//{
//    soma += Convert.ToInt32(n);
//    //Console.WriteLine(n);
//}

//double media = (double)soma / idades.Length;

//Console.WriteLine($"A média das idades é: {media}");

//string teste = "Unimar Linguagem de programação";
//Console.WriteLine(teste.ToUpper());
//Console.WriteLine(teste.ToLower());
//Console.WriteLine(teste.Length);
//Console.WriteLine(teste.Trim());

//string textoComEspaco = "   Alguma coisa    ";
//string textoEspacoTrim = textoComEspaco.Trim();
//Console.WriteLine(textoEspacoTrim);

//string str = "Programa é legal";

//string result = str.Replace("Programa", "PHP");
//Console.WriteLine(result);

//string nomeCompleto = "Bianca Campos";
//int posicao = nomeCompleto.IndexOf("C");
//Console.WriteLine(posicao);

//string nomeCompleto2 = "Bianca Vitória";
//string nome2 = nomeCompleto2.Substring(6, 8);
//Console.WriteLine(nome2);

string texto1 = "A imaginação é mais importante que o conhecimento";

int pos = texto1.IndexOf("mais");

Console.WriteLine(texto1.Substring(pos + 5));  