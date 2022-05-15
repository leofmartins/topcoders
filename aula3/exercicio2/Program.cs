/* 
    Programa que recebe dez inteiros e determina
    qual é o menor e maior valor
*/

int[] colecaoDeNumeros = new int[10];
    
    double maiorValor = 0;
    double menorValor = 0;

    Console.WriteLine("DESCUBRA O MAIOR E O MENOR VALOR ENTRE 10 NÚMEROS");

    for (int i = 0; i < 10; i++)
    {
      Console.WriteLine($"Digite o {i + 1}º número:");
      colecaoDeNumeros[i] = double.Parse(Console.ReadLine());
    }

    menorValor = colecaoDeNumeros[0];
    maiorValor = colecaoDeNumeros[0];
    
    for (int i = 1; i < colecaoDeNumeros.Length; i++)
    {
      if (colecaoDeNumeros[i] > maiorValor)
      {
        maiorValor = colecaoDeNumeros[i];
      }
    }
    
    for (int i = 1; i < colecaoDeNumeros.Length; i++)
    {
      if (colecaoDeNumeros[i] < menorValor)
      {
        menorValor = colecaoDeNumeros[i];
      }
    }

    Console.WriteLine($"O menor valor entre os números digitados é {menorValor}");

    Console.WriteLine($"O maior valor entre os números digitados é {maiorValor}");