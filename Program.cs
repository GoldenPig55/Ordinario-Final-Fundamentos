namespace OrdinarioFinalRaul
{
    class Program
    {
        public static AdminsitracionDeMascotas administracionDeMascotas = new AdminsitracionDeMascotas();
        public static AdminsitracionDePersonas administracionDePersonas = new AdminsitracionDePersonas();
        static void Main(string[] args)
        {
            ProgramaPrincipal();
        }

        private static void ProgramaPrincipal()
        {
            Console.WriteLine("Bienvenido al centro de mascotas Mascotifelices");
            Console.WriteLine("[1] - Administracion de Centro  [2] - Aministracion de Adopciones  [3] - Administracion de Bienestar Animal");
            Console.WriteLine("[4] - Simulacion de interacciones  [5] - Finalizar Programa");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu)
            {
                case 1:
                    Console.Clear(); // Implementado Correctamente
                    AdministracionDelCentro();
                    break;

                case 2:
                    Console.Clear();// Implementado Correctamente
                    AdministracionDeAdopciones();
                    break;

                case 3:
                    Console.Clear();// Implementado Correctamente
                    AdministracionDeBienestarAnimal();
                    break;

                case 4:
                    Console.Clear();
                    ProgramaPrincipal();
                    break;

                case 5:
                    Console.Clear();// Implementado Correctamente
                    Console.ReadKey();
                    break;

                default:
                    Console.Clear();// Implementado Correctamente
                    Console.WriteLine("La opcion que introdujo no es valida, favor de colocar otro numero");
                    ProgramaPrincipal();

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
                case 1:
                    Console.Clear();// Implementado Correctamente
                    AdministracionDePersonas();
                    break;

                case 2:
                    Console.Clear();// Implementado Correctamente
                    AdministracionDeMascotas();
                    break;

                case 3:
                    Console.Clear();// Implementado Correctamente
                    ProgramaPrincipal();
                    break;

                default:
                    Console.Clear();// Implementado Correctamente
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    break;
            }
        }

        #region "Opciones dentro de Administracion de Centro"
        public static void AdministracionDePersonas()
        {
            Console.WriteLine("Entro a Administración de Personas.  Favor de eleir una opcion");
            Console.WriteLine("[1] - Mostrar todas las personas registradas  [2] - Registrar Persona Nueva  [3] - Buscar personas por Nombre");
            Console.WriteLine("[4] - Examinar Persona  [5] - Regresar a Menu Anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu)
            {
                case 1:
                    Console.Clear();
                    administracionDePersonas.MostrarPersonasRegistradas();
                    AdministracionDePersonas();
                    break;

                case 2:
                    Console.Clear();
                    administracionDePersonas.RegistrarPersonaNueva();
                    AdministracionDePersonas();
                    break;

                case 3:
                    Console.Clear();
                    administracionDePersonas.BuscarPersonaPorNombre();
                    AdministracionDePersonas();
                    break;

                case 4:
                    Console.Clear();
                    AdministracionDePersonas();
                    break;

                case 5:
                    Console.Clear();// Implementado Correctamente
                    AdministracionDelCentro();
                    break;

                default:
                    Console.Clear();// Implementado Correctamente
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    AdministracionDePersonas();
                    break;
            }

        }

        public static void AdministracionDeMascotas()
        {
            Console.WriteLine("Entro a Administración de Mascotas.  Favor de eleir una opcion");
            Console.WriteLine("[1] - Mostrar Todas Las mascotas registradas  [2] - Registrar Mascota Nueva  [3] - Buscar mascotas por especie");
            Console.WriteLine("[4] - Buscar mascotas por nombre  [5] - Examinar Mascota  [6] - Volver al menu anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu)
            {
                case 1:
                    Console.Clear(); // Implementado Correctamente
                    administracionDeMascotas.MostrarMascotasRegistradas();
                    Console.ReadKey();

                    Console.Clear();
                    AdministracionDeMascotas();
                    break;

                case 2:
                    Console.Clear(); // Implementado Correctamente
                    administracionDeMascotas.RegistrarMascotaNueva();
                    AdministracionDeMascotas();
                    break;

                case 3:
                    Console.Clear(); // Implementado Correctamente
                    administracionDeMascotas.BuscarMascotaPorEspecie();
                    Console.ReadKey();

                    Console.Clear();
                    AdministracionDeMascotas();
                    break;

                case 4:
                    Console.Clear();
                    administracionDeMascotas.BuscarMascotaPorNombre();
                    Console.ReadKey();

                    Console.Clear();
                    AdministracionDeMascotas();
                    break;

                case 5:
                    Console.Clear();
                    AdministracionDeMascotas();
                    break;

                case 6:
                    Console.Clear();// Implementado Correctamente
                    AdministracionDelCentro();
                    break;

                default:
                    Console.Clear();// Implementado Correctamente
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    AdministracionDeMascotas();
                    break;
            }
        }
        #endregion

        private static void AdministracionDeAdopciones()
        {
            Console.WriteLine("Entro a Administracion De Adopciones.  Elija una Opcion");
            Console.WriteLine("[1] - Ver mascotas disponibles para Adopcion [2] - Adoptar mascota  [3] - Regresar a Menu Anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu)
            {
                case 1:
                    Console.Clear();
                    AdministracionDeAdopciones();
                    break;

                case 2:
                    Console.Clear();
                    AdministracionDeAdopciones();
                    break;

                case 3:
                    Console.Clear();// Implementado Correctamente
                    ProgramaPrincipal();
                    break;

                default:
                    Console.Clear();// Implementado Correctamente
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    AdministracionDeAdopciones();
                    break;
            }

        }
        private static void AdministracionDeBienestarAnimal()
        {
            Console.WriteLine("Entro a Administracion De Bienestar Animal.  Elija una Opcion");
            Console.WriteLine("[1] - Servicio de Spa [2] - Corte de pelo  [3] - Regresar a Menu Anterior");

            int SeleccionarOpcionDeMenu = int.Parse(Console.ReadLine());
            switch (SeleccionarOpcionDeMenu)
            {
                case 1:
                    Console.Clear();
                    AdministracionDeBienestarAnimal();
                    break;

                case 2:
                    Console.Clear();
                    AdministracionDeBienestarAnimal();
                    break;

                case 3:
                    Console.Clear();// Implementado Correctamente
                    ProgramaPrincipal();
                    break;

                default:
                    Console.Clear();// Implementado Correctamente
                    Console.WriteLine("La opcion que introdujo No es valida, favor de colocar otro numero");
                    AdministracionDeBienestarAnimal();
                    break;
            }
        }
        #endregion
    }

    class AdminsitracionDeMascotas
    {
        public List<Perro> RegistroDePerros = new List<Perro>();
        public List<Gato> RegistroDeGatos = new List<Gato>();
        public List<Capibara> RegistroDeCapibaras = new List<Capibara>();
        public void MostrarMascotasRegistradas()
        {
            if (RegistroDePerros.Count > 0)
            {
                Console.WriteLine("Perros Registrados");

                for (int i = 0; i < RegistroDePerros.Count; i++)
                {
                    Console.WriteLine($"Id : {RegistroDePerros[i].Id} Nombre : {RegistroDePerros[i].Nombre}");
                }
            }
            else
            {
                Console.WriteLine("No hay Perros registados");
                Program.AdministracionDeMascotas();
            }

            if (RegistroDeGatos.Count > 0)
            {
                Console.WriteLine("Gatos Registrados");

                for (int i = 0; i < RegistroDeGatos.Count; i++)
                {
                    Console.WriteLine($"Id : {RegistroDeGatos[i].Id} Nombre : {RegistroDeGatos[i].Nombre}");
                }
            }
            else
            {
                Console.WriteLine("No hay Gatos registados");
                Program.AdministracionDeMascotas();
            }

            if (RegistroDeCapibaras.Count > 0)
            {
                Console.WriteLine("Capibaras Registrados");

                for (int i = 0; i < RegistroDeCapibaras.Count; i++)
                {
                    Console.WriteLine($"Id : {RegistroDeCapibaras[i].Id} Nombre : {RegistroDeCapibaras[i].Nombre}");
                }
            }
            else
            {
                Console.WriteLine("No hay Capibaras registados");
                Program.AdministracionDeMascotas();
            }

        }

        public void RegistrarMascotaNueva()
        {
            Console.WriteLine("Exelente, Vemos que quiere registrar una mascota, Cual es la especie de la mascota?");
            Console.WriteLine("Perro [p]  Gato [g]  Capibara [c]");
            string especieDeLaMascota = Console.ReadLine();
            string Nombre;

            switch (especieDeLaMascota)
            {
                case "p":
                    Console.Clear();
                    Console.WriteLine("Wow, Es un perro muy bonito, Cual es su nombre?");
                    Nombre = Console.ReadLine();

                    Console.WriteLine($"Que bonito es tu Perro, {Nombre} ah sido agregado al registo");
                    Perro perro = new Perro(Nombre);

                    RegistroDePerros.Add(perro);

                    break;

                case "g":
                    Console.Clear();
                    Console.WriteLine("Wow, Es un gato muy bonito, Cual es su nombre?");
                    Nombre = Console.ReadLine();

                    Console.WriteLine($"Que bonito es tu Gato, {Nombre} ah sido agregado al registo");
                    Gato gato = new Gato(Nombre);

                    RegistroDeGatos.Add(gato);
                    break;

                case "c":
                    Console.Clear();
                    Console.WriteLine("Wow, Es un capibara muy bonito, Cual es su nombre?");
                    Nombre = Console.ReadLine();

                    Console.WriteLine($"Que bonito es tu Capibara, {Nombre} ah sido agregado al registo");
                    Capibara capibara = new Capibara(Nombre);

                    RegistroDeCapibaras.Add(capibara);
                    break;

                default:
                    Console.WriteLine("La opcion que usted puso NO EXISTE, favor de escojer otra");
                    RegistrarMascotaNueva();
                    break;

            }
        }

        public void BuscarMascotaPorEspecie()
        {
            Console.WriteLine("Que especie es la mascota que etsa buscando ?");
            Console.WriteLine("Perro [p]  Gato [g]  Capibara [c]");
            string Especie = Console.ReadLine();

            switch (Especie)
            {
                case "p":
                    if (RegistroDePerros.Count > 0)
                    {
                        Console.WriteLine("Perros Registrados");

                        for (int i = 0; i < RegistroDePerros.Count; i++)
                        {
                            Console.WriteLine($"Id : {RegistroDePerros[i].Id} Nombre : {RegistroDePerros[i].Nombre}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay Perros registados");
                    }
                    break;

                case "g":
                    if (RegistroDeGatos.Count > 0)
                    {
                        Console.WriteLine("Gatos Registrados");

                        for (int i = 0; i < RegistroDeGatos.Count; i++)
                        {
                            Console.WriteLine($"Id : {RegistroDeGatos[i].Id} Nombre : {RegistroDeGatos[i].Nombre}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay Gatos registados");
                    }
                    break;

                case "c":
                    Console.WriteLine("Capibaras Registrados");

                    if (RegistroDeCapibaras.Count > 0)
                    {
                        Console.WriteLine("Capibaras Registrados");

                        for (int i = 0; i < RegistroDeCapibaras.Count; i++)
                        {
                            Console.WriteLine($"Id : {RegistroDeCapibaras[i].Id} Nombre : {RegistroDeCapibaras[i].Nombre}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay Capibaras registados");
                    }
                    break;

                default:
                    Console.WriteLine("La opcion que usted puso NO EXISTE, favor de escojer otra");
                    BuscarMascotaPorEspecie();
                    break;
            }
        }

        public void BuscarMascotaPorNombre()
        {
            Console.WriteLine("Cual es el nombre de la mascota que esta buscando");
            int p = -1, g = -1, c = -1;
            string Nombre = Console.ReadLine();
            bool MascotaEncontrada = false;

            for (int i = 0; i < RegistroDePerros.Count; i++)
            {
                MascotaEncontrada = (RegistroDePerros[i].Nombre) == Nombre;

                if (MascotaEncontrada)
                {
                    p = i;
                }
            }

            for (int i = 0; i < RegistroDeGatos.Count; i++)
            {
                MascotaEncontrada = (RegistroDeGatos[i].Nombre) == Nombre;
                if (MascotaEncontrada)
                {
                    g = i;
                }
            }

            for (int i = 0; i < RegistroDeCapibaras.Count; i++)
            {
                MascotaEncontrada = (RegistroDeCapibaras[i].Nombre) == Nombre;
                if (MascotaEncontrada)
                {
                    c = i;
                }
            }

            if (MascotaEncontrada)
            {
                Console.WriteLine("Su mascota fue encontrada en el registro");

                if (p >= 0)
                {
                    Console.WriteLine($"Su mascota es : {RegistroDePerros[p].Id}  -  {RegistroDePerros[p].Nombre}");
                }
                else if (g >= 0)
                {
                    Console.WriteLine($"Su mascota es : {RegistroDeGatos[g].Id}  -  {RegistroDeGatos[g].Nombre}");
                }
                else if (c >= 0)
                {
                    Console.WriteLine($"Su mascota es : {RegistroDeCapibaras[c].Id}  -  {RegistroDeCapibaras[c].Nombre}");
                }
            }
            else
            {
                Console.WriteLine("Su mascota No fue encontrada en el registro");
            }

        }
    }
    class AdminsitracionDePersonas
    {
        public List<Persona> RegistroDePersonas = new List<Persona>();
        public void MostrarPersonasRegistradas()
        {
            if (RegistroDePersonas.Count > 0)
            {
                Console.WriteLine("Peronas Registradas");

                foreach (var persona in RegistroDePersonas)
                {
                    Console.WriteLine($"Id : {persona.Id}  Nombre : {persona.Nombre}");
                }
            }
            else
            {
                Console.WriteLine("No hay Personas registadas.");
                Program.AdministracionDePersonas();
            }
        }

        public void RegistrarPersonaNueva()
        {
            Console.WriteLine("Excelente, vemos que quiere registrar una persona.");
            string Nombre;

            Console.WriteLine("Ingrese el nombre de la Persona.");
            Nombre = Console.ReadLine();

            Console.WriteLine($"Bienvenido {Nombre}, ah sido agregado al registo");
            Persona persona = new Persona(Nombre);

            RegistroDePersonas.Add(persona);
        }
        public void BuscarPersonaPorNombre()
        {
            Console.WriteLine("Cual es el nombre de la persona que esta buscando");
            int p = -1;
            string Nombre = Console.ReadLine();
            bool PersonaEncontrada = false;

            for (int i = 0; i < RegistroDePersonas.Count; i++)
            {
                PersonaEncontrada = (RegistroDePersonas[i].Nombre) == Nombre;
                if (PersonaEncontrada)
                {
                    p = i;
                }
            }

            if (PersonaEncontrada)
            {
                Console.WriteLine("Su persona fue encontrada en el registro");
                Console.WriteLine($"Su persona es : {RegistroDePersonas[p].Id}  -  {RegistroDePersonas[p].Nombre}");
            }
            else
            {
                Console.WriteLine("Su mascota No fue encontrada en el registro");
            }

        }
    }
}

interface IMascota
{
    void HacerRuido();
    void CambiarDueño();
}
interface IAcariciable
{
    void ResponderACaricia();
}
public enum Temperamento
{
    amable,
    nervioso,
    agresivo
}

#region "Clases de las mascotas"
public class Perro : IMascota, IAcariciable
{
    private int ultimoIdPerro;
    private int id;
    private string nombre;
    private int edad;
    private Temperamento temperamento;
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
            else
            {
                throw new Exception("La edad debe ser entre 1 y 14 años.");
            }
        }
    }
    public Temperamento Temperamento;
    public string Dueño;
    public Perro(string nombre)
    {
        Nombre = nombre;
        Id = ultimoIdPerro + 1;
        ultimoIdPerro++;
    }

    public void HacerRuido()
    {
        Console.WriteLine($"El perro {Nombre} hace ruido. Guau Guau!");
    }
    public void CambiarDueño()
    {
        // implementar cambiar dueño
        Console.WriteLine($"El perro {Nombre} a cambiado de dueño a (nombre de la persona).");
    }
    public void Gruñir()
    {
        Console.WriteLine($"El perro {Nombre} se pone a gruñir. Grrr!");
    }
    public void MoverCola()
    {
        Console.WriteLine($"El perro {Nombre} mueve su colita. Que chulo!");
    }
    public void ResponderACaricia()
    {
        Console.WriteLine($"El perro {Nombre} responde moviendo su colita. Que bonito!");
    }
}
public class Gato : IMascota, IAcariciable
{
    private int ultimoIdGato;
    private int id;
    private string nombre;
    private int edad;
    private Temperamento temperamento;
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
            if (edad <= 18 && edad > 0)
            {
                edad = value;
            }
            else
            {
                throw new Exception("La edad debe ser entre 1 y 18 años.");
            }
        }
    }
    public Temperamento Temperamento;
    public string Dueño;
    public Gato(string nombre)
    {
        Nombre = nombre;
        Id = ultimoIdGato + 1;
        ultimoIdGato++;
    }

    public void HacerRuido()
    {
        Console.WriteLine($"El gato {Nombre} hace ruido. Guau Guau!");
    }
    public void CambiarDueño()
    {
        // implementar cambiar dueño
        Console.WriteLine($"El gato {Nombre} a cambiado de dueño a (nombre de la persona).");
    }
    public void Ronronear()
    {
        Console.WriteLine($"El gato {Nombre} se pone a ronronear.. prrr...");
    }
    public void Rasguñar()
    {
        Console.WriteLine($"El gato {Nombre} rasguña! Ouch!");
    }
    public void ResponderACaricia()
    {
        Console.WriteLine($"El perro {Nombre} responde moviendo su colita. Que bonito!");
    }

}
public class Capibara : IMascota, IAcariciable
{
    private int ultimoIdCapibara;
    private int id;
    private string nombre;
    private int edad;
    private Temperamento temperamento;
    private string dueño;

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }
    public string Nombre;
    public int Edad
    {
        get { return edad; }
        set
        {
            if (edad <= 11 && edad > 0)
            {
                edad = value;
            }
            else
            {
                throw new Exception("La edad debe ser entre 1 y 11 años.");
            }
        }
    }
    public Temperamento Temperamento;
    public string Dueño;
    public Capibara(string nombre)
    {
        Nombre = nombre;
        Id = ultimoIdCapibara + 1;
        ultimoIdCapibara++;
    }
    public void HacerRuido()
    {
        Console.WriteLine($"La capibara {Nombre} hace ruido. Cui Cui!");
    }
    public void CambiarDueño()
    {
        // implementar cambiar dueño
        Console.WriteLine($"La capibara {Nombre} a cambiado de dueño a (nombre de la persona).");
    }
    public void ResponderACaricia()
    {
        Console.WriteLine($"La capibara no puede ser acariciada, solo admirada.");
    }
}
public class Persona
{
    private int ultimoIdPersona = 0;
    private int id;
    private string nombre;

    public int Id
    {
        get { return id; }
        private set { id = value; }
    }
    public string Nombre
    {
        get { return nombre; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) == false)
            {
                nombre = value.Trim();
            }
            else
            {
                throw new Exception("El nombre no puede estar vacio");
            }
        }
    }
    public Persona(string nombre)
    {
        Nombre = nombre;
        Id = ultimoIdPersona + 1;
        this.ultimoIdPersona = ultimoIdPersona + 1;
    }

    public void ObtenerMascotas()
    {
        // devolver lista de mascotas que la persona posee
    }
    public void ObtenerMascotasPorId()
    {
        // obtener mascota por busqueda de ID
    }
    public void AgregarMascotas()
    {
        // Agregar mascota toma un objeto que se comporte como una mascota, y muestra un texto que diga algo tipo Raúl agrega a Milaneso a sus mascotas , seguido por el comportamiento de hacer ruido de la mascota adoptada
    }
    public void Acariciar()
    {
        // acariciar mascota seleccionada
    }
    public void AcariciarMascotas()
    {
        // acariciar todas las mascotas
    }
}
#endregion
