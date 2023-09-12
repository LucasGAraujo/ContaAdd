
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class AdicionarConta
    {
        List<Conta> contas= new List<Conta>();

        public void AdicionaConta(Conta conta)
        {
            contas.Add(conta);
        }
    public List<Conta> ExibirContas()
    {
        return contas;
    }
}

