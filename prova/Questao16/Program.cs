int opcaoSenha = 0;

List<string> senhas = new List<string>();

while(opcaoSenha != 5)
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1. Emitir uma Senha de Atendimento Preferencial");
    Console.WriteLine("2. Emitir uma Senha de Atendimento Comum");
    Console.WriteLine("3. Cancelar uma Senha de Atendimento");
    Console.WriteLine("4. Convocar a Próxima Senha de Atendimento");
    Console.WriteLine("5. Sair do Sistema");
    opcaoSenha = Console.ReadLine();

        switch(opcaoSenha)
    {
        case 1:
            senhas.Add("P" + (string)(preferencial.lengh + 1));
            break;
        case 2:
            senhas.Add("C" + (string)(preferencial.lengh + 1);
            break;
        case 3:
            Console.WriteLine("Digite a senha a ser cancelada:");
            string senhaExluir = Console.ReadLine();
            break;

        case 4:
            
        case 5:
            Console.WriteLine("Saindo do sistema...");
            break;
    }
}