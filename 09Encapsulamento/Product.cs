using System.Globalization;

namespace Projeto09Encapsulamento
{
    internal class Product
    {   //atributos privados começam com underline seguido de letra minúscula.
        private string _nome;
        private double _preco;
        private int _quantidade;

        //construtor. O construtor dá um valor inicial ao objeto. Se não der o valor iniciará como 0 ou null (string)
        //Sobrecarga é ter vários construtores.
        //A partir do momento que você cria um construtor com valores, o construtor padrão (com 0 e null) fica
        //indisponível, tornando necessária a criação do construtor em branco para uso do construtor padrão.
        public Product() { }

        public Product(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //public Product(string nome, double preco)
        //{
        //    _nome = nome;
        //    _preco = preco;
        //    _quantidade = 5; //por padrão, não precisaria colocar o atributo 0, pois o default já é 0. Ou seja
        //    //ficariam apenas 2 atributos: nome e preco.
        //}

        public string GetNome() { return _nome; }

        public double GetPreco() { return _preco; }

        public int GetQuantidade() { return _quantidade; }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
