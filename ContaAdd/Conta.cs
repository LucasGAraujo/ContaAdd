using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public  class Conta
    {
        public Guid Id { get; set; }
        public string _Nome { get; set; }
        public int _Idade { get; set; }
        public double Saldo = 100;

        public Conta(string nome, int idade)
        {
            Id= Guid.NewGuid();
            _Nome= nome;
            _Idade= idade;
        }
        public virtual void Sacar(double valor)
        {
            if (valor < Saldo && Saldo > 0)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo negativo, impossivel sacar");
            }
        }
        public void Depositar(double valor)
        {
            if(valor > 0)
            {
                Saldo += valor;
            }else
            {
                Console.WriteLine("Impossivel depositar valor menor que 0");
            }
        }
    }

