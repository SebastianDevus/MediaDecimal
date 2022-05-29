int quantosNumeros, contador;
double numeroDigitado, soma, media, maiorNumero, menorNumero;

// Declara valores para usar variaveis sem erros
contador = 1;
soma = 0;
maiorNumero = 0;
menorNumero = 0;

Console.Clear();

Console.WriteLine("--- Média Decimal ---");
Console.Write("Quantos números? ");
quantosNumeros = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

while (contador <= quantosNumeros)
{
    Console.Write($"Insira o número {contador}: ");
    numeroDigitado = Convert.ToDouble(Console.ReadLine());

    soma += numeroDigitado;

    // Se o número digitado for o primeiro, ele será o maior e menor
    // Caso contrário, será ou o maior ou o menor
    if (contador == 1)
    {
        maiorNumero = numeroDigitado;
        menorNumero = numeroDigitado;
    }
    else
    {
        if (numeroDigitado > maiorNumero)
        {
            maiorNumero = numeroDigitado;
        }
        if (numeroDigitado < menorNumero)
        {
            menorNumero = numeroDigitado;
        }
    }

    // Aumentando o contador a cada operação
    contador++;
}

// Calcula media
media = soma / quantosNumeros;

// Exibindo resultados
Console.WriteLine("\n-----------------");
Console.WriteLine($"Soma...: {soma}");
Console.WriteLine($"Média..: {media:N2}");
Console.WriteLine($"Maior..: {maiorNumero}");
Console.WriteLine($"Menor..: {menorNumero}");
Console.WriteLine("-----------------\n");

// Pausando após a operação para o usuário ver o resultado e limpar o console depois
Console.Write("Pressione uma tecla para finalizar...");
Console.ReadKey();
Console.Clear();