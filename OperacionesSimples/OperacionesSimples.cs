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
            double salida=0;
            try
            {
                salida = entuno / entdos;
                return salida;
            }
            catch (DivideByZeroException) {
                Console.WriteLine("\nDivision invalida de {0} entre cero",entuno);
                return 0;
            }
        }
    }
}
