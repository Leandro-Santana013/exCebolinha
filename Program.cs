// See https://aka.ms/new-console-template for more information
String frase = ""
Console.write("Digite uma frase: ")
frase = Console.Readline()!;

Console.Write($"Nova frase: {frase.Replace('r', 'l').Replace('R', 'L')}");
