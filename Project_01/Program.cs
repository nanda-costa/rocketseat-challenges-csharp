namespace Project_01;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Início dos Desafios ---\n");

        // 1. Mensagens Iniciais
        Mensageiro mensageiro = new Mensageiro();
        mensageiro.Perguntar("Por favor, digite seu nome:");
        
        NomeSobrenome nomeSobrenome = new NomeSobrenome();
        nomeSobrenome.NomeCompleto();

        // 2. Operações Matemáticas
        Console.WriteLine("\n--- Operações Matemáticas ---");
        Valores valor = new Valores();
        double n1 = 10.5, n2 = 5.2;
        
        Console.WriteLine($"Soma: {valor.Soma(n1, n2)}");
        Console.WriteLine($"Subtração: {valor.Subtracao(n1, n2)}");
        Console.WriteLine($"Multiplicação: {valor.Multiplicacao(n1, n2):F2}");
        
        if (n2 != 0)
            Console.WriteLine($"Divisão: {valor.Divisao(n1, n2):F2}");
        else
            Console.WriteLine("Erro: Divisão por zero.");

        // 3. Contagem de Caracteres
        Console.WriteLine("\n--- Contador de Caracteres ---");
        Console.Write("Digite uma frase: ");
        QntCaracteres analisador = new QntCaracteres();
        string entrada = Console.ReadLine() ?? "";
        Console.WriteLine($"Total (sem espaços): {analisador.Contar(entrada)}");

        // 4. Validação de Placa
        Console.WriteLine("\n--- Validador de Placa ---");
        Console.Write("Digite a placa: ");
        PlacaValida valida = new PlacaValida();
        string input = Console.ReadLine() ?? "";
        Console.WriteLine($"Placa válida: {valida.Verificar(input)}");

        // 5. Formatação de Datas
        Console.WriteLine("\n--- Formatos de Data ---");
        GerenciadorData gerenciadorData = new GerenciadorData();
        gerenciadorData.ExibirFormatos();

        Console.WriteLine("\n--- Fim dos Desafios. Pressione qualquer tecla para sair. ---");
        Console.ReadKey();
    }
}