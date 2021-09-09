using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco("Rua Antonio fagundes",
                "11443-000", "Guarujá", "São Paulo");

                Cliente cliente = new Cliente ("Rodrigo", "123456789", "9745612", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                string senha = "abcd1234";

                conta.Abrir(senha);

                Console.WriteLine("Conta: " + conta.Situacao + ": " conta.NumeroConta + "-" conta.DigitoVerificador);

                conta.Sacar(10,senha);

                Console.WriteLine("Saldo: " + conta.Saldo);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

        }
    }
}
