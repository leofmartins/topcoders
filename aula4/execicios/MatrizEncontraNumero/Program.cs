/*  
    Programa que lê números digitados pelo usuário e
    insere numa matriz 5x5.
    Em seguida o programa lê um outro número digitado pelo
    e verifica se ele está contido na matriz.
    Se sim, retorna sua posição.
*/

int[,] matriz = new int[5, 5];
int numeroProcurar = 0;
bool numeroEncontrado = false;
int posicaoLinhaNumeroEncontrado = 0;
int posicaoColunaNumeroEncotrado = 0;

// lê os números digitados pelo usuário e insere na matriz
for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
            Console.WriteLine($"Digite o número da posição [{linha}, {coluna}]:");
            matriz[linha, coluna] = int.Parse(Console.ReadLine());
    }
}

// lê um número digitado pelo usuário e verifica se está contido na matriz
Console.WriteLine("Digite um número para verificar se está contido na matriz:");

numeroProcurar = int.Parse(Console.ReadLine());

for (int linha = 0; linha < 5; linha++)
{
    for (int coluna = 0; coluna < 5; coluna++)
    {
        if (matriz[linha, coluna] == numeroProcurar)
        {
            numeroEncontrado = true;
            posicaoLinhaNumeroEncontrado = linha;
            posicaoColunaNumeroEncotrado = coluna;
            break;
        }
    }
}

// exibe se número foi encontrado e sua posição
if (numeroEncontrado)
{
    Console.WriteLine($"O número {numeroProcurar} foi encontrado na matriz na posiçlão [{posicaoLinhaNumeroEncontrado}, {posicaoColunaNumeroEncotrado}]");
}