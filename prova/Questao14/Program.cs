List<string> motoristas = new List<string>();

for (int contador = 1; contador <= 15; contador++)
{
    Console.WriteLine("\nQual o seu nome?");
    string nome = Console.ReadLine();

    bool sucessoLerIdade = false;
    
    int idade = 0;

    while (!sucessoLerIdade)
    {
        Console.WriteLine("\nQual a sua idade?");
        sucessoLerIdade = int.TryParse((Console.ReadLine()), out idade) ;
    }
    
    if (idade < 18)
    {
        continue;
    }
    else
    {
        Console.WriteLine("\nVocê possui CNH? (S - sim)");
        bool possuiCNH = Console.ReadLine().ToUpper() == "S";

        motoristas.Add(nome);
    }
}

if (motoristas.Count > 0)
{
    Console.WriteLine("\nOs motorias são");

    foreach(string motorista in motoristas)
    {
        Console.WriteLine(motorista);
    }
}
else
{
    Console.WriteLine("\nViagem não será realizada devido falta de motoristas.");
}