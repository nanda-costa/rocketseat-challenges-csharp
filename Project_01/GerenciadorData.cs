namespace Project_01;

public class GerenciadorData
{
    public void ExibirFormatos()
    {
        DateTime dataAtual = DateTime.Now;
        
        Console.WriteLine($"Completo: {dataAtual.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss")}");

        Console.WriteLine($"Simples: {dataAtual.ToString("dddd, MMMM yyyy")}");
        
        Console.WriteLine($"Hora: {dataAtual.ToString("HH:mm")}");
        
        Console.WriteLine($"Mês por extenso: {dataAtual.ToString("dd 'de' MMMM 'de' yyyy")}");
    }
}