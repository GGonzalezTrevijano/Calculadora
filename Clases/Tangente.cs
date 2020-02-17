using System;

namespace Proyecto_Calculadora
{
    class Tangente
    {
        public double Num13 { get; set; }

        public double _tang;

        public double Tang
        {
            get { return _tang; }

            set
            {
                _tang = Math.Tan(Num13);
            }            
        }
    }
}
