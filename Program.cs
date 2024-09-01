using System.Collections.Concurrent;
using System.Security.Cryptography;
using XPInc.Models;


int numero = 11;
bool ehPar = numero % 2 == 0;

System.Console.WriteLine($"o número {numero} "+(ehPar ? "é par" : "é impar"));


if(numero %2 == 0)
{
    System.Console.WriteLine($"o número {numero} é par");
}
else
{
    System.Console.WriteLine($"o número {numero} é impar");
}




Pessoa fabricio = new Pessoa("Fabricio","Zulian");

(string nome, string sobrenome) = fabricio;

Console.WriteLine($"Nome: {nome} {sobrenome}");


(int id, string nome, string sobrenome) tupla = (1, "Fabricio", "Zulian");

ValueTuple<int, string, string> tupla2 = (1, "teste", "teste");
var tupla3 = Tuple.Create(1, "teste", "teste");
System.Console.WriteLine($"ID: {tupla.id}");
System.Console.WriteLine($"Nome: {tupla.nome}");
System.Console.WriteLine($"Sobrenome: {tupla.sobrenome}");

LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhas, QuantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if (sucesso)
{
    foreach(var linha in linhas)
    {
        System.Console.WriteLine(linha);
    }

}
else
{
    System.Console.WriteLine("Não foi possível ler o arquivo");
}



Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP","São Paulo");
estados.Add("BA","Bahia");
estados.Add("MG","Minas Gerais");


foreach(KeyValuePair<string,string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("SP");
System.Console.WriteLine("_______________");
foreach(KeyValuePair<string,string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

System.Console.WriteLine("_______________");

estados["BA"] = "Estado da bahia atualizado";
foreach(KeyValuePair<string,string> item in estados)
{
    System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}


Stack<int> pilha = new Stack<int>();

pilha.Push(2);
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach(int item in pilha)
{
    Console.WriteLine(item);
}

System.Console.WriteLine($"Removendo item: {pilha.Pop()}");

pilha.Push(20);

foreach(int item in pilha)
{
    System.Console.WriteLine(item);
}



Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    System.Console.WriteLine(item);
}


System.Console.WriteLine($"\n removendo o elemento: {fila.Dequeue()}");

foreach (int item in fila)
{
    System.Console.WriteLine(item);
}


//new ExemploExcecao().Metodo1();


try
{
string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

foreach (string line in linhas)
{
    System.Console.WriteLine(line);
}
}
catch (Exception ex)
{
    System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
*/
