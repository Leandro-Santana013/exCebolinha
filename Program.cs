// See https://aka.ms/new-console-template for more information
string frase = "Eu troco as letras, não falo bem, mas meus amigos não troco por ninguém";
Console.WriteLine(frase);
Console.Write($"Nova frase: {frase.Replace('r', 'l').Replace('R', 'L')}");