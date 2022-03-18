using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicios_Fixacao_Classes_Prop_Constr
{
    internal class Banco
    {
        public int Conta { get; private set; } //para dizer que o número da conta não pode ser alterado // Autoproperties

        public string Nome { get; set; }     // Autoproperties    

        public double ValorDep { get; private set; } // Autoproperties


        public Banco(int conta, string nome) //Construtor com 2 argumentos - não coloquei o objeto VALORDEP por ser numérico o padrão inicial é ZERO
        {
            Conta = conta;
            Nome = nome;
        }

        public Banco(int conta, string nome, double depositoInicial) : this(conta, nome)  //Construtor 3 argumentos, aproveitei o outro usando :this
        {
            AdicionarDinheiro(depositoInicial); 
        }

        public double AdicionarDinheiro(double quantia)
        {
            return ValorDep += quantia;
        }

        public double Saque(double quantia)
        {
            return ValorDep -= quantia + 5.00; 
        }

        public override string ToString()
        {
            return "Conta: " + Conta + ", Titular: " + Nome + ", Saldo: $" + ValorDep.ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
