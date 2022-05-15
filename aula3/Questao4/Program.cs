int nDucks;

Console.WriteLine("MÚSICA DOS PATINHOS\nDigite o número de patinhos para ver a letra da música:");
nDucks = int.Parse(Console.ReadLine());

if (nDucks >= 2)
{
  for (int i = nDucks; i > 2; i--)
  {
    Console.WriteLine($"{i} patinhos foram passear\nAlém das montanhas\nPara brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas só {i - 1} patinhos voltaram de lá.\n");
  }
  Console.WriteLine($"2 patinhos foram passear\nAlém das montanhas\nPara brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas só 1 patinho voltou de lá.\n\n1 patinho foi passear\nAlém das montanhas\nPara brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas nenhum patinho voltou de lá.\n\nA mamãe patinha foi procurar\nAlém das montanhas\nNa beira do mar\nA mamãe gritou: Quá, quá, quá, quá\nE os {nDucks} patinhos voltaram de lá.\n");
}
else if ( nDucks == 1)
  Console.WriteLine("1 patinho foi passear\nAlém das montanhas\nPara brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas nenhum patinho voltou de lá.\n\nA mamãe patinha foi procurar\nAlém das montanhas\nNa beira do mar\nA mamãe gritou: Quá, quá, quá, quá\nE o patinho voltou de lá.\n");
else
  Console.WriteLine("Ah, sem patinhos, não tem música...");