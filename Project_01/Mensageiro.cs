namespace Project_01;

public class Mensageiro
{
    public void Perguntar(string mensagem)
    {
        Console.WriteLine(mensagem);
        string nome;
        nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vinda!");
    }
}