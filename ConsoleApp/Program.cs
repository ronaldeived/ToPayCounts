using ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ClienteTitular ronaldeived = new ClienteTitular("Ronaldeived");
            ClienteCoTitular raquel = new ClienteCoTitular(ronaldeived, "Raquel");
            Conta net = new Conta("Net", 139, Convert.ToDateTime("5/12/2020"), ronaldeived);

            Console.WriteLine($"Nome Cliente Titular: {ronaldeived.Nome} \nÉ titular: {ronaldeived.Titular}");
            Console.WriteLine($"Nome Cliente Co-titular: {raquel.Nome}\nÉ titular: {raquel.Titular} \nCliente Titular deste co-titular: {raquel.ClienteTitular.Nome}");



            Console.ReadLine();
        }
    }
}
