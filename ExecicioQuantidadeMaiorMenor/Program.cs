int idades, cmaior = 0, cmenor = 0, c = 0;

for (; c < 10; c++)
{
    do
    {
        Console.WriteLine($"Digite a {c +1}° idade: ");
        idades = int.Parse(Console.ReadLine());
    } while (idades <= 0);
    if (idades >= 18)
    {
        cmaior++;

    }
    else
    {
        cmenor++;
    }
}
Console.WriteLine($"Possuem {cmaior} maiores de idade e {cmenor} menores de idade");

