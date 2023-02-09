// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo 3!");

string[] vetorpalavras = new string[5];

Console.WriteLine("Tamanho vetor:" + vetorpalavras.Length);

Console.WriteLine("Atribuir valor em vetor ");
for (int i = 0; i < vetorpalavras.Length; i++)
{
    Console.WriteLine($"Digite um nome para posicao {i}:");
    vetorpalavras[i] = (Console.ReadLine());
}

Console.WriteLine("Impressão do vetor ");
for (int i = 0; i < vetorpalavras.Length; i++)
{
        Console.WriteLine($"posicao {i} valor de {vetorpalavras[i]}");
}
