using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TesterCore
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new
                ArgumentOutOfRangeException("Valor do depósito não pode ser menor ou igual a zero.");

            }
            else
            {
                Saldo += valor;
            }
        }
    }

}
