string frase, modifica = "";
char c1, c2;

Console.WriteLine("Inserire una frase");
frase = Console.ReadLine();

do
{
    Console.WriteLine("Inserire il carattere da cercare");
    c1 = Convert.ToChar(Console.ReadLine());
    if (frase.Contains(c1) == false) 
    { 
        Console.WriteLine("Il carattere non e' contenuto nella frase originale, inserirne uno contenuto");
    }
}while(frase.Contains(c1) == false);

Console.WriteLine("Inserire il carattere da sostituire");
c2 = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < frase.Length; i++)
{
    if (c1 == frase[i])
    {
        modifica += c2;
    }
    else
    {
        modifica += frase[i];
    }
}
Console.WriteLine(modifica);