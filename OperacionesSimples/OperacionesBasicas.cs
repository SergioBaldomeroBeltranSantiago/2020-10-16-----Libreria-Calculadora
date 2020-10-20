using System;

namespace Calculadora
{
    public class OperacionesBasicas
    {
        public float Suma(float entuno, float entdos) {
            return entuno + entdos;
        }

        public float Resta(float entuno, float entdos) {
            return entuno - entdos;
        }

        public float Mult(float entuno, float entdos) {
            return entuno * entdos;
        }

        public float Div(float entuno, float entdos) {
            try
            {
                float salida = entuno / entdos;
                return salida;
            }
            catch (DivideByZeroException) {
                return float.NaN;
            }
        }

    }
}
