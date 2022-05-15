int[,] matriz = new int[5, 5];

int numeroProcurar = 0;

bool sucessoLerNumeroProcurar = false;
bool numeroEncontrado = false;

int posicaoLinhaNumeroEncontrado = 0;
int posicaoColunaNumeroEncotrado = 0;

Console.WriteLine("PROGRAMA MATRIZ 5x5.\nPreencha a matriz e verifique se ela contém determinado número.");

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        int numeroDigitado = 0;

        bool sucessoLerNumeroParaMatriz = false;

        while (!sucessoLerNumeroParaMatriz)
        {
            Console.WriteLine($"\nDigite um número inteiro para ocupar a posição Linha {linha + 1}, Coluna {coluna + 1} na matriz:");
            sucessoLerNumeroParaMatriz = int.TryParse(Console.ReadLine(), out numeroDigitado);
        }

        matriz[linha, coluna] = numeroDigitado;
    }
}

Console.WriteLine("\nMatriz:");

Console.WriteLine("\tCol 1\tCol 2\tCol 3\tCol 4\tCol 5");

for (int linha = 0; linha < 5; linha++)
{
    Console.Write($"Lin {linha + 1}\t");

    for (int coluna = 0; coluna < 5; coluna++)
    {
            Console.Write($"{matriz[linha, coluna]}\t");
    }
    
    Console.WriteLine("");
}

while(!sucessoLerNumeroProcurar)
{
    Console.WriteLine("\nDigite um número para verificar se está contido na matriz:");
    sucessoLerNumeroProcurar = int.TryParse(Console.ReadLine(), out numeroProcurar);
}

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        if (matriz[linha, coluna] == numeroProcurar)
        {
            numeroEncontrado = true;
            posicaoLinhaNumeroEncontrado = ++linha;
            posicaoColunaNumeroEncotrado = ++coluna;
            break;
        }

        if (numeroEncontrado)
        {
            break;
        }
    }

    if (numeroEncontrado)
    {
        break;
    }
}

if (numeroEncontrado)
{
    Console.WriteLine($"\nO número {numeroProcurar} foi encontrado na matriz na posição Linha {posicaoLinhaNumeroEncontrado}, Coluna {posicaoColunaNumeroEncotrado}.");
}
else
{
    Console.WriteLine($"\nO número {numeroProcurar} não foi encontrado na matriz.");
}