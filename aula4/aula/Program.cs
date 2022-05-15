//criar matriz 5x5 e ler entradas do usuário
    int[,] matriz = new int[5, 5];
    int numeroAProcurar = 0;
    bool matrizContemNumero = false;
    int posicaoLinha = 0; 
    int posicaoColuna = 0;

    Console.WriteLine("ENCONTRAR VALOR NA MATRIZ\n");

    for (int linha = 0; linha < 5; linha++)
    {
      for (int coluna = 0; coluna < 5; coluna++)
      {
        Console.WriteLine($"Digite o valor a ser incluído na {linha} e da couluna {coluna}");
        
        matriz[linha, coluna] = int.Parse(Console.ReadLine());
      }
    }

    //Pede um número, verifica se está contido na matriz e retorna a posição
    Console.WriteLine("Digite um número para verificar se ele está contido na matriz e para ver qual a sua posição:");
    numeroAProcurar = int.Parse(Console.ReadLine());

    for (int linha = 0; linha < 5; linha++)
    {
      for (int coluna = 0; coluna < 5; coluna++)
      {
        if (matriz[linha, coluna] == numeroAProcurar)
        {
          matrizContemNumero = true;
          posicaoLinha = linha;
          posicaoColuna = coluna;
          break;
        }
      }
    }

    if (matrizContemNumero)
    {
      Console.WriteLine($"O número digitado está contido na matriz na posição {posicaoLinha}{posicaoColuna}");
    }
  }