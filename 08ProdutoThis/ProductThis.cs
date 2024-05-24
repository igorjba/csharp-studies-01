using System.Globalization;

namespace Projeto08ProdutoThis
{
    internal class Product
    {   //A classe define todos os dados que o objeto deve ter
        public string Nome;
        public double Preco;
        public int Quantidade;

        //construtor. O construtor dá um valor inicial ao objeto. Se não der o valor iniciará como 0 ou null (string)
        //Sobrecarga é ter vários construtores.
        //A partir do momento que você cria um construtor com valores, o construtor padrão (com 0 e null) fica
        //indisponível, tornando necessária a criação do construtor em branco para uso do construtor padrão.
        //public Product(string nome, double preco, int quantidade)
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    Quantidade = quantidade;
        //}

        public Product()
        {
            Quantidade = 10;
        }
        public Product(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Product(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
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
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
