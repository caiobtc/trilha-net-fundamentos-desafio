namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;// criando uma variavel do tipo decimal chamda de precoInicial
        private decimal precoPorHora = 0;// criando uma variavel do tipo decimal chamada precoPorHora
        private List<string> veiculos = new List<string>();// criando uma lista chamada veiculos

        public Estacionamento(decimal precoInicial, decimal precoPorHora)// criando uma propriedade e passando os parametros
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // pedido para o usuario digita o nome da placa
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            // armazenando a entrada do usuario e O método ToUpper é utilizado em strings para converter todos os caracteres alfabéticos de uma string para maiúsculas.
            string placa = Console.ReadLine().ToUpper();

            if (veiculos.Contains(placa))
            {
                Console.WriteLine($"Veiculo da placa é: {placa}, ja está estacionado, coloque outro veículo que não esteje estacionado!");
                return;
            }

            else
            {
                veiculos.Add(placa);  
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (!veiculos.Any(x => x.ToUpper() == placa.ToUpper()))// A linha de código verifica se não há nenhum veículo na coleção veiculos com uma placa (convertida para maiúsculas) igual à placa fornecida. 
            {
                Console.WriteLine("Esse veículo não se encontra em nosso sistema");
                return;
            }
                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
        
            int horas = 0; // começando com zero
            decimal valorTotal = 0; // começando com zero

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

            int.TryParse(Console.ReadLine(), out horas); // Essa linha de código está lendo uma entrada do usuário a partir do console, convertendo-a para um número inteiro (caso possível) e armazenando o resultado na variável horas. 

            valorTotal = (precoInicial + precoPorHora) * horas; // estar somando o preço inicial e preço por hora e multiplicando por horas e armazenando em valorTotal
            // Remover a placa digitada da lista de veículos
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                //int contadorVeiculo = 1;
                foreach (string Veiculo in veiculos)
                {
                    Console.WriteLine(Veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
            
        }
    }
}
