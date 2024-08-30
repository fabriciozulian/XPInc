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