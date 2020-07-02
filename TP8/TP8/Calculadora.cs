using System;
using System.Collections.Generic;
using System.Text;

namespace testTP8
{
    class Calculadora
    {
        float numero1;
        float numero2;
        string operacion;
        DateTime tiempo;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public string Operacion { get => operacion; set => operacion = value; }
        public DateTime Tiempo { get => tiempo; set => tiempo = value; }

        float Suma()
        {
            return Numero1 + Numero2;
        }
        float Resta()
        {
            return Numero1 - Numero2;
        }
        float Multiplicacion()
        {
            return Numero1 * Numero2;
        }
        float Division()
        {
            return Numero1 / Numero2;
        }

        public override string ToString()
        {
            return Convert.ToString(Tiempo) + " ---> " + Convert.ToString(Operacion);
        }
    }
}
