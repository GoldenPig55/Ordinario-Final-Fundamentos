using System;

namespace OrdinarioFinalRaul
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    interface Mascota
    {
        private int id;
        private string nombre;
        private int edad;
        private var temperamento;
        private string dueño;
        void HacerRuido();
        void CambiarDueño();
    }
}