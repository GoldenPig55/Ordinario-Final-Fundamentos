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

        #region "Opciones dentro de Programa Principal"
        private static void AdministracionDelCentro() 
        {
            Console.WriteLine("Entro a Administracion Del Centro.  Elija una Opcion");
            Console.WriteLine("[1] - Administracion de Personas  [2] - Adminsitracion de Mascotas  [3] - Regresar a Menu Anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu) 
            {
                case 1:Console.Clear();
                    AdministracionDePersonas();
                    break;

                case 2: Console.Clear();
                    AdministracionDeMascotas();
                    break;

                case 3: Console.Clear();
                    ProgramaPrincipal();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    break;
            }
        }

        #region "Opciones dentro de Administracion de Centro"
        private static void AdministracionDePersonas() 
        {
            Console.WriteLine("Entro a Administración de Personas.  Favor de eleir una opcion");
            Console.WriteLine("[1] - Mostrar todas las personas registradas  [2] - Registrar Persona Nueva  [3] - Buscar personas por Nombre");
            Console.WriteLine("[4] - Examinar Persona  [5] - Regresar a Menu Anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu) 
            {
                case 1: Console.Clear();
                    break;

                case 2: Console.Clear();
                    break;

                case 3: Console.Clear();
                    break;

                case 4: Console.Clear();
                    break;

                case 5: Console.Clear();
                    AdministracionDelCentro();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    AdministracionDePersonas();
                    break;
            }

        }

        private static void AdministracionDeMascotas() 
        {
            Console.WriteLine("Entro a Administración de Mascotas.  Favor de eleir una opcion");
            Console.WriteLine("[1] - Mostrar Todas Las mascotas registradas  [2] - Registrar Macota Nueva  [3] - Buscar mascotas por especie");
            Console.WriteLine("[4] - Buscar mascotas por nombre  [5] - Examinar Mascota  [6] - Volver al menu anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu)
            {
                case 1:
                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    AdministracionDelCentro();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    AdministracionDeMascotas();
                    break;
            }
        }
        #endregion

        #endregion
    }
    interface Mascota
    { 
        void HacerRuido();
        void CambiarDueño();
    }

    public class Perro : Mascota
    {
        private int id;
        private string nombre;
        private int edad;
        private string temperamento;
        private string dueño;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre;
        public int Edad
        {
            get { return edad; }
            set
            {
                if (edad <= 14 && edad > 0)
                {
                    edad = value;
                }
            }
        }
        public string Temperamento;
        public string Dueño;

        public void HacerRuido()
        {
            Console.WriteLine("${Nombre} hace ruido. Guau Guau!");
        }
        public void CambiarDueño()
        {
            // implementar cambiar dueño
        }
        public void Gruñir()
        {
            Console.WriteLine("${Nombre} se pone a gruñir. Grrr!");
        }
        public void MoverCola()
        {
            Console.WriteLine("${Nombre} mueve su colita. Que chulo!");
        }
    }
}