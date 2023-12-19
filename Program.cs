using System;

namespace OrdinarioFinalRaul
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramaPrincipal();
            Console.ReadKey();
        }

        private static void ProgramaPrincipal() 
        {
            Console.WriteLine("Bienvenido al centro de mascotas Mascotifelices");
            Console.WriteLine("[1] - Administracion de Centro  [2] - Aministracion de Adopciones  [3] - Administracion de Bienestar Animal");
            Console.WriteLine("[4] - Simulacion de interacciones  [5] - Finalizar Programa");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu) 
            {
                case 1:Console.Clear();
                    AdministracionDelCentro();
                    break;

                case 2:Console.Clear();

                    break;

                case 3:Console.Clear();

                    break;

                case 4:Console.Clear();

                    break;

                case 5:Console.Clear();

                    break;

                default:Console.Clear();
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    break;
            }
        }

        private static void AdministracionDelCentro() 
        {
            Console.WriteLine("Entro a Administracion Del Centro.  Elija una Opcion");
            Console.WriteLine("[1] - Administracion de Personas  [2] - Adminsitracion de Mascotas  [3] - Regresar a Menu Anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu) 
            {
                case 1:Console.Clear();
                    break;

                case 2: Console.Clear();
                    break;

                case 3: Console.Clear();
                    break;
            }
        }

        private static void AdministracionDePersonas() 
        {
            Console.WriteLine("Entro a Administración de Personas.  Favor de eleir una opcion");
            Console.WriteLine("[1] - Mostrar todas las personas registradas  [2] - Registrar Persona Nueva  [3] - Buscar personas por Nombre");
            Console.WriteLine("[4] - Examinar Persona  [5] - ");

        }
    }
    interface Mascota
    {
        /*private int id;
        private string nombre;
        private int edad;
        private var temperamento;
        private string dueño;*/
        void HacerRuido();
        void CambiarDueño();
    }
}