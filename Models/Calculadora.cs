using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoCalculadora.Interfaces;

namespace ProjetoCalculadora.Models
{
    public class Calculadora : ICalculadora
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Substrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public double RaizQuadrada(double num)
        {
            return Math.Sqrt(num);
        }

        public double Potencia(double baseNum, double expoente)
        {
            return Math.Pow(baseNum, expoente);
        }
    }
}