Console.Clear();

int numero, resultado;
string nome = "";

Console.WriteLine("Diga seu nome:");
nome = Console.ReadLine()!;

Console.WriteLine($"\n*****Seja bem-vindo(a) a Tabuada {nome}******");

Console.WriteLine("Digite o número desejado:");
if (int.TryParse(Console.ReadLine(), out numero))
{
    for (int i = 0; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($" {numero} X {i} = {resultado} ");
    }
    Console.WriteLine("Aperte qualquer tecla para encerrar... Volte Sempre!");
    Console.ReadKey();
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Número inválido, digite apenas número inteiros!");
    Console.ResetColor();
    Console.WriteLine("Aperte qualquer tecla para encerra... Volte Sempre!");
    Console.ReadKey();
}
