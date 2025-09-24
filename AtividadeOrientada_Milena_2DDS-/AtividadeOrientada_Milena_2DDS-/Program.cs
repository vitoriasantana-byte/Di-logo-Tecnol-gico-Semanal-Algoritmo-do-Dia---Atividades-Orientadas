using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra ou frase: ");
        string texto = Console.ReadLine().ToLower(); // Coloca tudo em minúsculo

        int vogais = 0;
        int consoantes = 0;

        foreach (char letra in texto)
        {
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                vogais++;
            }
            else if (letra >= 'a' && letra <= 'z') // Qualquer letra que não seja vogal
            {
                consoantes++;
            }
            // Espaços e símbolos são ignorados
        }

        Console.WriteLine($"Número de vogais: {vogais}");
        Console.WriteLine($"Número de consoantes: {consoantes}");
    }
}