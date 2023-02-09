// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int[] x= new int[5];

Console.WriteLine("Tamanho vetor:" + x.Length);

Console.WriteLine("Atribuir valor em vetor ");
for (int i = 0; i < x.Length; i++)
{
    Console.WriteLine($"Digite um valor para posicao {i}:");
    x[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Impressão do vetor ");
for (int i = 0; i < x.Length; i++)
{
        Console.WriteLine($"posicao {i} valor de {x[i]}");
}



Array.Resize(ref x, x.Length+1);

Console.WriteLine("Novo Tamanho vetor:" + x.Length);