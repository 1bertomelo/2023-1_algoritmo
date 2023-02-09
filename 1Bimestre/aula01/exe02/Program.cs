// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exemplo 2!");

string palavra = "beto";

Console.WriteLine($"Tamanho do vetor é {palavra.Length} caracteres ");

foreach (char letra in palavra)
{
    Console.WriteLine($"{letra}");
}

Console.WriteLine($"Transformando as letras em maisculas!");
foreach (char letra in palavra)
{
    Console.WriteLine($"{Char.ToUpper(letra)}");
}


Console.WriteLine($"Transformando as letras em minusculas!");
foreach (char letra in palavra)
{
    Console.WriteLine($"{Char.ToLower(letra)}");
}
