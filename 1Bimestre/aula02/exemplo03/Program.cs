// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo 03!");
List<int> listaInteiros = new List<int>();

int qtdeIteiros = 5;

for (int i = 0; i < qtdeIteiros; i++)
{
    Console.WriteLine("Digite um valor para inserir:");
    int valor = Convert.ToInt32(Console.ReadLine());
    listaInteiros.Add(valor);
}

Console.WriteLine("Impressão da lista!");
foreach (var item in listaInteiros)
{
 Console.WriteLine($"Valor = {item}");   
}


Console.WriteLine("Digite um valor para filtramos acima:");
int valorPesquisa = Convert.ToInt32(Console.ReadLine());

var resultadoPesquisa = listaInteiros.Where(l => l >= valorPesquisa);

Console.WriteLine("Impressão da lista apos o filtro!");
foreach (var item in resultadoPesquisa)
{
 Console.WriteLine($"Valor = {item}");   
}

var resultadoOrdenado = listaInteiros.OrderBy(l => l);

Console.WriteLine("Impressão da lista apos ordenação!");
foreach (var item in resultadoOrdenado)
{
 Console.WriteLine($"Valor = {item}");   
}

var resultadoOrdenadoDesc = listaInteiros.OrderByDescending(l => l);
Console.WriteLine("Impressão da lista apos ordenação descendente!");
foreach (var item in resultadoOrdenadoDesc)
{
 Console.WriteLine($"Valor = {item}");   
}
