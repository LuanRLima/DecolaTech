using ExemploPOO.Interfaces;

namespace ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        // public int Dividir(int num, int num2)
        // {
        //    return num / num2;
        // }

        public int Multiplicar(int num, int num2)
        {
            return num * num2;
        }

        public int Somar(int num, int num2)
        {
            return num + num2;
        }

        public int Subtrair(int num, int num2)
        {
            return num - num2;
        }
    }
}