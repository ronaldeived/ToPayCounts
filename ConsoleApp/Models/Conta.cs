using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class Conta
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public DateTime Vencimento { get; private set; }
        public ClienteTitular ClienteTitular { get; private set; }
        public ClienteCoTitular ClienteCoTitular { get; private set; }

        public Conta(string nome, double valor, DateTime vencimento, ClienteTitular titular)
        {
            Nome = nome;
            Valor = valor;
            Vencimento = vencimento;
            ClienteTitular = titular;
            if (titular.CoTitular != null)
            {
                ClienteCoTitular = titular.CoTitular;
            }
        }

        public Conta()
        {
        }
    }
}
