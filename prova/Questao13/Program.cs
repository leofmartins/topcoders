int caixasLeite = 0;
int ovos= 0;

decimal precoLeite = 3.15m;
decimal precoDuziaOvos = 7.00m;

bool mercadoPossuiOvos = false;
bool temSol = false;
bool mercadoPossuiEstacionamentoCoberto = false;
bool vitorEsqueceuCarteira = false;


Console.WriteLine("Solução item 1");

Console.WriteLine("\nDigite a quantidade de caixa de leite para Vitor comprar:");
caixasLeite = int.Parse(Console.ReadLine());

Console.WriteLine("\nDigita a quantidade de ovos para Vitor comprar:");
ovos = int.Parse(Console.ReadLine());

Console.WriteLine("\nInforme se o mercado possui ovos (S -sim):");
mercadoPossuiOvos = Console.ReadLine().ToUpper() == "S";

Console.WriteLine($"\nVitor trouxe 6 caixas de leite.");

Console.WriteLine("\nSOLUÇÃO ITEM 2:");

if (mercadoPossuiOvos)
{
    Console.WriteLine($"\nVitor trouxe {caixasLeite} caixa de leite e {ovos} ovos.");
}
else
{
    Console.WriteLine($"\nVitor trouxe {caixasLeite} caixas de leite.");
}

Console.WriteLine("\nSOLUÇÃO ITEM 3:");

Console.WriteLine($"\nValor total da compra: R$ {Math.Round((decimal)caixasLeite * precoLeite + ((decimal)ovos / 12) * precoDuziaOvos, 2)}.");

Console.WriteLine("\nSOLUÇÃO ITEM 4:");

if (mercadoPossuiOvos && precoDuziaOvos < 6)
{
    Console.WriteLine($"\nVitor comprou {ovos} ovos e gastou R$ {Math.Round(((decimal)precoDuziaOvos /12) * ovos, 2)}.");
}
else
{
    Console.WriteLine("\nVitor não comprou ovos.");
}

Console.WriteLine("\nSOLUÇÃO ITEM 5");

Console.WriteLine("\nEstá fazendo sol? (S - sim):");
temSol = Console.ReadLine().ToUpper() == "S";

Console.WriteLine("O mercado tem estacionamento coberto? (S - sim):");
mercadoPossuiEstacionamentoCoberto = Console.ReadLine().ToUpper() == "S";

if (temSol || mercadoPossuiEstacionamentoCoberto)
{
    Console.WriteLine("\nVitor vai ao mercado");
}
else
{
    Console.WriteLine("\nVitor não vai ao mercado");
}

Console.WriteLine("\nSOLUÇÃO ITEM 6:");

Console.WriteLine("\nVitor esqueceu a carteira? (S - sim)");
vitorEsqueceuCarteira = Console.ReadLine().ToUpper() == "S";

if (vitorEsqueceuCarteira)
{
    Console.Write("Fiado de forma alguma, vá para casa espertão!");
}
else
{
    Console.WriteLine("FIM!");
}