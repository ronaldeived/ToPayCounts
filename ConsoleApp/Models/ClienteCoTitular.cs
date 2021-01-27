using ConsoleApp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class ClienteCoTitular : ClientePessoa
    {
        
        public ClienteTitular ClienteTitular { get; private set; }
        public Titular Titular { get ; private set ; }
        public ClienteCoTitular(ClienteTitular clienteTitular, string nomeCoTitular) : base(nomeCoTitular)
        {
            ClienteCoTitular CoTitular = new ClienteCoTitular(clienteTitular,  nomeCoTitular);
            ClienteTitular = clienteTitular;
            Titular = Titular.Nao;
            SetCoTitular(clienteTitular, CoTitular);
        }

        protected override void SetCoTitular(ClienteTitular clienteTitular, ClienteCoTitular CoTitular)
        {
            clienteTitular.CoTitular = this.ClienteTitular.CoTitular;
        }
    }
}
