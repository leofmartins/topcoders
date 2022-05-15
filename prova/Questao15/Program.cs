Console.WriteLine("Digite o valor que deseja sacar:");
int valorSacar = int.Parse(Console.ReadLine());

int notas100 = 0;
int notas50 = 0;
int notas20 = 0;
int notas10 = 0;
int notas5 = 0;
int notas2 = 0;

notas100 = (int)valorSacar / 100;

valorSacar = valorSacar - (notas100 * 100);
   
notas50 = (int)valorSacar / 50;

valorSacar = valorSacar - (notas50 * 50);

notas20 = (int)valorSacar / 20;

valorSacar  = valorSacar - (notas20 * 20);

notas10 = (int)valorSacar / 10;

valorSacar = valorSacar - (notas10 * 10);

notas5 = (int)valorSacar / 5;

valorSacar = valorSacar - (notas5 * 5);

notas2 = (int)valorSacar / 2;

if (notas100 > 0)
{
    Console.WriteLine($"{notas100} notas de 100");
}

if (notas50 > 0)
{
    Console.WriteLine($"{notas50} notas de 50");
}

if (notas20 > 0)
{
    Console.WriteLine($"{notas20} notas de 20");
}

if (notas10 > 0)
{
    Console.WriteLine($"{notas10} notas de 10");
}

if (notas5 > 0)
{
    Console.WriteLine($"{notas5} notas de 5");
}

if (notas2 > 0)
{
    Console.WriteLine($"{notas2} notas de 2");
}