using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class ContaPoupança : Conta
{
    public ContaPoupança(string nome, int idade) : base(nome, idade)
    {
    }
    public void juros()
    {      
        Saldo = Saldo * 0.15;
    }
}

