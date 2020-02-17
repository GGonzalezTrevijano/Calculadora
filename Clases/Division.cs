using System;

namespace Proyecto_Calculadora
{
    public class Division
    {
        public int Num7 { get; set; }
        public int Num8 { get; set; }

        public decimal _dividir;

        public decimal Dividir
        {
            get { return _dividir; }

            set
            {
                if (Num7 < 1 && Num8 < 1)
                {
                    Console.WriteLine("El numero elegido es inferior a un numero divisible");
                }
                else
                {
                   _dividir = Num7 / Num8;
                }
            } 
        }
    }
}
