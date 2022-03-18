using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    internal class Produto
    {
        public string _nome { get; set; }          // Atributo Privativo
        public double Preco { get; private set; }  // AutoProperties
        public int Quantidade { get; private set; } // AutoProperties


        public Produto()                            // Construtores
        {

        }

        public Produto(string nome, double preco, int quantidade)    // Construtores
        {
            _nome = nome;                                            //
            Preco = preco;                                           //
            Quantidade = quantidade;                                 //
        }

        public string Nome                                           // Propriedades Customizadas
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 3)               // Propriedades Customizadas   
                {
                    _nome = value;
                }
            }
        }                                                            //
               
        public double ValorTotalEmEstoque()                          // Outros Métodos
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int adicionar)                 // Outros Métodos
        {
            Quantidade += adicionar;
        }

        public void RemoverProdutos(int remover)                     // Outros Métodos
        {
            Quantidade -= remover;
        }

        public override string ToString()                            // Outros Métodos
        {
            return _nome + ", $ " + Preco.ToString("F2") + ", " + Quantidade + " unidades, Total: $ " + ValorTotalEmEstoque().ToString("F2");
        }

    }
}
