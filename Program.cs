internal class Program
{
    private static void Main(string[] args)
    {
        double valorGasolina, valorAlcool, diferencaValores;
        int opcao;
        Console.WriteLine("Olá, Bem-Vindo ao Comparador de Preços Entre Gasolina e Álcool.Pressione ENTER para iniciar.");
        opcao = 0;
        Console.ReadKey();

       while(opcao != 2)
        {
            Console.WriteLine("Escolha Uma Opção:");
            Console.WriteLine("1 - Informar o Valor do Litro dos Combustíveis | 2 - Sair");
            opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                Console.WriteLine("Informe o Valor do Litro da Gasolina:");
                valorGasolina = double.Parse(Console.ReadLine());
                Console.WriteLine("Agora, Informe o Valor do Litro Álcool:");
                valorAlcool = double.Parse(Console.ReadLine());
                diferencaValores = valorAlcool / valorGasolina;
                if (diferencaValores == 0.70)
                {
                    Console.WriteLine("A relação entre o Valor do Litro do Álcool e do Litro da Gasolina é a mesma. Recomenda-se o uso de qualquer um dos dois.");
                }
                else if (diferencaValores > 0.70)
                {
                    Console.WriteLine("A relação entre o Valor do Litro do Álcool é maior do que o Litro da Gasolina. Recomenda-se o uso da GASOLINA.");
                }
                else
                {
                    Console.WriteLine("A relação entre o Valor do Litro do Álcool é menor do que o Litro da Gasolina. Recomenda-se o uso da ÁLCOOL.");
                }
                Console.WriteLine("Aperte ENTER para continuar");
                Console.ReadKey();
                Console.WriteLine("Deseja Efetuar Um Novo Cálculo?");
                Console.WriteLine("1 - Sim | 2 - Não");
                opcao = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Até Mais!");
    }
}