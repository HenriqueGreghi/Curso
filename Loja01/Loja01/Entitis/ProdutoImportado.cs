using System;
using System.Globalization;

namespace Loja01.Entitis
{
    class ProdutoImportado : Produto
    {
        public double TaxaImportação { get; set; }
        
        public ProdutoImportado()
        {

        }

        public ProdutoImportado(string nome, double valor, double taxaImportação)
            : base(nome, valor)
        {
            TaxaImportação = taxaImportação;
           
        }
        public double ValorTotalI()
        {
            return Valor + TaxaImportação;
        }
        
        public override string ValorEtiqueta()
        {
            return Nome
                + "$"
                + ValorTotalI().ToString("F2", CultureInfo.InvariantCulture)
                +"Valor de Importação: $" 
                +TaxaImportação.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }

}
