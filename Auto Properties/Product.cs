using System.Globalization;

namespace Projeto11AutoProperties
{
    internal class Product
    {   
        //Ordem sugerida de implementação das classes
        //Atributos privados
        //Propriedades autoimplmentadas
        //Construtores
        //Propriedades customizadas
        //Outros métodos da classe

        //Obs: assembly significa projeto. Uma solução tem vários projetos.
        private string _nome;
        public double Preco {  get; set; }
        public int Quantidade {  get; private set; }

        public Product() { }

        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
