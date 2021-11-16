using System;
using System.Globalization;

namespace Loja01.Entitis
{
    class ProdutoUsado : Produto
    {
        public DateTime DataFabricacao { get; set; }
       

        public ProdutoUsado()
        {

        }

        public ProdutoUsado(string nome, double valor,DateTime dataFabricacao)
            : base(nome, valor)
        {
            dataFabricacao = DataFabricacao;
           
        }

        public override string ValorEtiqueta()
        {
            return Nome
                +" (used) $ "
                + Valor.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: "
                + DataFabricacao.ToString("dd/mm/yyyy")
                + ")";
        }
    }
}
