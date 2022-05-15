/*
    Faça um programa com o seguinte menu:
    1 - Inserir sigla e idioma
    2 - Pesquisar sigla
    3 - Remover sigla
    4 - Pesquisar idioma
    Ao inserir, siga o formato: "pt-BR", "Portuguese (Brazil)"
    Na pesquisa, caso encontre, exiba o idioma,
    caso contrario, exiba mensagem "Sigla não cadastrada"
*/

Dictionary<string, string> dicionarioIdiomas = new Dictionary<string, string>();
int opcao;
string sigla, idioma;
bool respostaUsuario = true;

Console.WriteLine("PROGRAMA DICIONÁRIO DE IDIOMAS");

while (respostaUsuario)
{
    Console.WriteLine("\nEscolha uma opção:\n1 - Inserir sigla e idioma\n2 - Pesquisar sigla\n3 - Remover sigla\n4 - Pesquisar idioma");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nDigite a sigla (ex. pt-BR):");
            
            sigla = Console.ReadLine();
            
            Console.WriteLine("\nDigite o idioma [ex. Português (Brazil)]:");
            
            idioma = Console.ReadLine();
            
            if (!dicionarioIdiomas.ContainsKey(sigla))
            {
                dicionarioIdiomas.Add(sigla, idioma);

                Console.WriteLine("\nIdioma adicionado ao dicionário.");
            }
            else
            {
                Console.WriteLine("\nDicionário já contém esse idioma.");
            }
            
            break;
        case 2:
            Console.WriteLine("\nDigite a sigla que deseja pesquisar no dicionário (ex. pt-BR):");
            sigla = Console.ReadLine();
            if (dicionarioIdiomas.ContainsKey(sigla))
            {
                Console.WriteLine($"\nIdioma correspondente à sigla {sigla}: {dicionarioIdiomas[sigla]}");
            }
            else
            {
                Console.WriteLine("\nSigla não encontrada.");
            }
            break;
        case 3:
            Console.WriteLine("\nDigite a sigla para removar do dicionário (ex. pt-BR)");
            sigla = Console.ReadLine();
            if (dicionarioIdiomas.ContainsKey(sigla))
            {
                dicionarioIdiomas.Remove(sigla);
                Console.WriteLine("\nIdioma removido do dicionário.");
            }
            break;
        case 4:
            Console.WriteLine("\nDigite o idioma que deseja pesquisar no dicionário (ex. Português (Brazil))");
            idioma = Console.ReadLine();
            if (dicionarioIdiomas.ContainsValue(idioma))
            {
                foreach(KeyValuePair<string, string> item in dicionarioIdiomas)
                {
                    if (item.Value == idioma)
                    {
                        string idiomaEncontrado = item.Key;
                        Console.WriteLine($"\nA sigla correspondente ao idioma {idioma} é {idiomaEncontrado}");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nIdioma não encontrado.");
            }
            break;
        default:
            Console.WriteLine("\nOpção inválida.");
            break;
    }

    Console.WriteLine("\nDeseja faze mais uma ação (S - sim?)");
    respostaUsuario = Console.ReadLine().ToUpper() == "S";
}