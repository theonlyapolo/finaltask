class Pessoa // classe para criar as pessoas
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cidade { get; set; }
}
// tive que fazer com a parte de class pq tava dando erro na hora de definir a lista
class Program
{   // defino a lista Pessoa
    static List<Pessoa> pessoas = new List<Pessoa>();

    static void Main() // usei o main
    {
        Console.WriteLine("Cadastro de Pessoas\n");

        while (true) // rodar até a pessoa sair
        {
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 – Adicionar pessoa\n2 – Listar pessoas\n3 – Buscar pessoa\n4 – Sair");
            Console.WriteLine("Digite aqui: ");
            int opcao = Convert.ToInt32(Console.ReadLine()); // o número q ela escolher se torna inteiro

            if (opcao == 1) // adicionar
            {
                Console.WriteLine("\r\nProcesso de adicionar ativado...");
                // pega as informações e joga nas variaveis
                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite a idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite a cidade: ");
                string cidade = Console.ReadLine();

                // adiciona as variaveis na classe Pessoa que tem uma lista pessoa
                pessoas.Add(new Pessoa { Nome = nome, Idade = idade, Cidade = cidade }); // add nome, idade e cidade
                Console.WriteLine("Pessoa adicionada com sucesso!\n");
            }
            else if (opcao == 2) // listar
            {
                Console.WriteLine("\nProcesso de listar ativado...");
                foreach (Pessoa i in pessoas) // para cada item da classe Pessoa na lista pessoas
                {
                    Console.WriteLine("Nome: " + i.Nome); // printa o nome (item) da lista
                }
                Console.WriteLine("Listagem finalizada com sucesso!\n");
            }
            else if (opcao == 3) // buscar
            {
                Console.WriteLine("\nProcesso de busca ativado..."); 
                Console.WriteLine("Digite o nome da pessoa: ");
                string busca = Console.ReadLine();
                foreach (Pessoa i in pessoas)
                {
                    if (i.Nome == busca) { // se a pessoa estiver o nome igual ao digitado
                        Console.WriteLine("Pessoa achada!");
                        Console.WriteLine("Nome: " + i.Nome); // printa o nome dela
                    }
                }
                Console.WriteLine("Busca finalizada com sucesso!\n");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Saindo...");
                break; // quebra o loop
            }
            else
            {
                Console.WriteLine("Opção Inválida. Tente novamente.");
            }
        }
    }
}
