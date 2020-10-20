using System;

namespace Calculadora
{
    public class OperacionesSimples
    {
        public double Suma(double entuno, double entdos) {
            return entuno + entdos;
        }

        public double Resta(double entuno, double entdos) {
            return entuno - entdos;
        }

        public double Mult(double entuno, double entdos) {
            return entuno * entdos;
        }

        public double Div(double entuno, double entdos) {
            try
            {
                double salida = entuno / entdos;
                return salida;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("\nDivision invalida de {0} entre cero\n",entuno);
                return double.NaN;
            }
        }
    }
}
