using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ContaCorrente : Conta
    {
        public ContaCorrente(string nome, int idade) : base(nome, idade)
        {
        }
        public void juros()
        {
            Saldo = Saldo * 0.05;
        }
    public override void Sacar(double valor)
    {
       Saldo -= valor;
    }
}
 

