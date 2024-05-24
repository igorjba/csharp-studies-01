using System.Globalization;

namespace Projeto07Produto
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
        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Product() { }
        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5; //por padrão, não precisaria colocar o atributo 0, pois o default já é 0. Ou seja
            //ficariam apenas 2 atributos: nome e preco.
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
