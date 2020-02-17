using System;

namespace Proyecto_Calculadora
{
    public class Seno
    {
        public double Num11 { get; set; }

        public double _sen;
        public double Sen
        {
            get { return _sen; }
            set
            {
                _sen = Math.Sin(Num11);
            }
        }
    }
}