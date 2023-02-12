// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo 02!");
List<string> listaNomes = new List<string>();

int qtNomes = 5;

for (int i = 0; i < qtNomes; i++)
{
    Console.WriteLine("Digite um nome para inserir na lista:");
    string nome = Console.ReadLine();
    listaNomes.Add(nome);
}

Console.WriteLine("Impressão lista");
foreach (var item in listaNomes)
{
     Console.WriteLine($"Valor {item}");
}

Console.WriteLine("Digite um nome para pesquisar na lista:");
string nomePesquisa = Console.ReadLine();

if(listaNomes.Contains(nomePesquisa)){
     Console.WriteLine($"O nome {nomePesquisa} encontrado na posição {listaNomes.IndexOf(nomePesquisa)} ");
}
else {
     Console.WriteLine($"O nome {nomePesquisa} não encontrado {listaNomes.IndexOf(nomePesquisa)} ");
}