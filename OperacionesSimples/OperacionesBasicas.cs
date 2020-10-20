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
            if (entdos != 0)
            {
                return entuno / entdos;
            }
            else {
                return float.NaN;
            }
        }

        public float Elev(float entuno, float potencia) {
            return (float)Math.Pow(entuno,potencia);
        }

        public float Modu(float entuno, float entdos) {
            if (entdos != 0)
            {
                return entuno % entdos;
            }
            else {
                return float.NaN;
            }
        }

        public float Raiz(float entuno, float raiz) {
            if (raiz >= 0)
            {
                return (float)Math.Pow(entuno, (1 / raiz));
            }
            else {
                return float.NaN;
            }
        }
    }
}
