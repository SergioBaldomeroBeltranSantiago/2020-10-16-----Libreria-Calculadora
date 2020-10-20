using System;

namespace Calculadora
{
    public class OperacionesBasicas
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
                return double.NaN;
            }
        }

    }
}
