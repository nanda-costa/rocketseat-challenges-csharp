namespace Project_01;

public class NomeSobrenome
{
    public void NomeCompleto()
    {
        string nome = Console.ReadLine();
        
        string sobrenome = Console.ReadLine();
        
        string resultado = $"Olá, {nome} {sobrenome}!";
        Console.WriteLine(resultado);
        
    }
}