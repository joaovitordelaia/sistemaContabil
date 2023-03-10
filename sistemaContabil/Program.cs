using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaContabil
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente clienteJoao = new Cliente();
            Cliente clienteIzione = new Cliente();
            Cliente clienteJulio = new Cliente();
            Agencia agenciaCentro = new Agencia();
            Agencia agenciaConceicao = new Agencia();
            Conta contaJoao = new Conta();
            Conta contaIzione = new Conta();
            Conta contaJulio = new Conta();
            CartaoCredito cdcJoao = new CartaoCredito();





            clienteJoao.codigo = 1;
            clienteJoao.nome = "João";

            clienteIzione.codigo = 2;
            clienteIzione.nome = "Izione";

            clienteJulio.codigo = 3;
            clienteJulio.nome = "Julio";

            agenciaCentro.numero = "2489";
            agenciaConceicao.numero = "4545";

            contaJoao.numero = "8746";
            contaJoao.saldo = 4.000;
            contaJoao.limite = 500;

            contaIzione.numero = "6478";
            contaIzione.saldo = 5.000;
            contaIzione.limite = 3.000;

            contaJulio.numero = "8456";
            contaJulio.saldo = 7.000;
            contaJulio.limite = 1.000;

            cdcJoao.numero = "1111.2222.3333.4444";
            cdcJoao.dataValidade = DateTime.Parse("10/10/2025");
            cdcJoao.cliente = clienteJoao;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Cliente 1: ");
            Console.WriteLine("Nome: " + clienteJoao.nome);
            Console.WriteLine("Código: " + clienteJoao.codigo);
            Console.WriteLine("o Cartão é: " + cdcJoao.cliente.nome);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Cliente 2: ");
            Console.WriteLine("Nome: " + clienteIzione.nome);
            Console.WriteLine("Código: " + clienteIzione.codigo);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Cliente 3: ");
            Console.WriteLine("Nome: " + clienteIzione.nome);
            Console.WriteLine("Código: " + clienteJulio.codigo);
            Console.WriteLine("---------------------------------------------");


            Console.ReadKey();


        }
    }
}
