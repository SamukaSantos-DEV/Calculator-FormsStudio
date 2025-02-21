using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_Aula
{
    class Operacoes
    {
        public double a, b;

        public double Adicao()
        {
            return a + b;
        }
        public double Sub()
        {
            return a - b;
        }
        public double Mult()
        {
            return a * b;
        }
        public double Divisao()
        {
            return a / b;
        }
        public double Raiz()
        {
            return Math.Sqrt(a);
        }
        public double Exp()
        {
            return Math.Pow(a, b);
        }
        public double Porcentual()
        {
            return (a/100)*b;
        }
        public double Elevado()
        {
            return a * a;
        }
        public double Npi()
        {
            return a * 3.14159265358;
        }
        



    }
}
