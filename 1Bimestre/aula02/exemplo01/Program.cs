// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo Lista 1!");
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


Console.WriteLine("Digite um valor para buscar e remover:");
int valorPesquisa = Convert.ToInt32(Console.ReadLine());

if(listaInteiros.Contains(valorPesquisa)){
    Console.WriteLine($"Valor {valorPesquisa} encontrado na posição {listaInteiros.IndexOf(valorPesquisa)} e removido!");
    listaInteiros.Remove(valorPesquisa);
}
else {
     Console.WriteLine($"Valor {valorPesquisa} não encontrado");
}

Console.WriteLine("Impressão da lista atualizada!");
foreach (var item in listaInteiros)
{
 Console.WriteLine($"Valor = {item}");   
}
