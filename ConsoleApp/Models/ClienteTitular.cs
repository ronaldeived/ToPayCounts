using ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class ClienteTitular : ClientePessoa
    {
        protected static int _countCoTitular { get; set; }
        public ClienteCoTitular CoTitular { get; set; }
        public ClienteTitular(string nomeCliente) : base (nomeCliente) 
        {
            Titular = Titular.Sim;
        }
        public Titular Titular { get ; private set; }

    }
}
