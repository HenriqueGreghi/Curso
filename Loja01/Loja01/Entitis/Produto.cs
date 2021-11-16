using System.Globalization;

namespace Loja01.Entitis
{
    class Produto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        

        public Produto()
        {
        }

        public Produto(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
            
        }
        public virtual string ValorEtiqueta()
        {
            return Nome
                + " $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
