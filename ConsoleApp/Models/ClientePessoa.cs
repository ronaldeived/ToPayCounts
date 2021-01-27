using ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public abstract class ClientePessoa
    {
        public string Nome { get; private set; }
        public ClientePessoa(string nome)
        {
            Nome = nome;
        }
        protected virtual void SetCoTitular(ClienteTitular clienteTitular, ClienteCoTitular CoTitular)
        {
        }
    }
}
