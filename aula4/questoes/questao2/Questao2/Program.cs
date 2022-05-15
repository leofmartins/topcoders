List<string> listaAlunos = new List<string> {};
bool respostaUsuario = true;

Console.WriteLine("PROGRAMA LISTA ALUNOS");

while (respostaUsuario)
{
    Console.WriteLine("\nDigite o nome de um aluno para aidioná-lo à lista:");
    listaAlunos.Add(Console.ReadLine());
    
    Console.WriteLine("\nDeseja inserir outro nome (S - sim, N - não)?");
    respostaUsuario = Console.ReadLine().ToUpper() == "S"; 
}

Console.WriteLine($"\nForam adicionados {listaAlunos.Count} alunos.");
    
Console.WriteLine("\nOs nomes dos alunos na lista são:");

foreach( string nome in listaAlunos)
{
    Console.WriteLine($"{nome}");
}