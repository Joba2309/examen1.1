using System;
using System.Collections.Generic;

class Menu
{
    private List<Empleado> empleados = new List<Empleado>();

    // Método para mostrar el menú principal
    public void MostrarMenuPrincipal()
    {
        Console.WriteLine("Menú Principal:");
        Console.WriteLine("1. Agregar Empleados");
        Console.WriteLine("2. Consultar Empleados");
        Console.WriteLine("3. Modificar Empleados");
        Console.WriteLine("4. Borrar Empleados");
        Console.WriteLine("5. Inicializar Arreglos");
        Console.WriteLine("6. Reportes");
        Console.WriteLine("7. Salir");
    }

    // Resto de métodos de la clase Menu...
class Menu
{
    private List<Empleado> empleados = new List<Empleado>();

    public void MostrarMenu()
    {
        Console.WriteLine("Menú Principal:");
        Console.WriteLine("1. Agregar Empleados");
        Console.WriteLine("2. Consultar Empleados por Cédula");
        Console.WriteLine("3. Listar Empleados por Nombre");
        Console.WriteLine("4. Calcular y Mostrar el Promedio de Salarios");
        Console.WriteLine("5. Calcular y Mostrar el Salario Más Alto y el Más Bajo");
        Console.WriteLine("6. Salir");
    }

    public void Ejecutar()
    {
        bool salir = false;
        while (!salir)
        {
            MostrarMenu();
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarEmpleado();
                    break;
                case "2":
                    ConsultarEmpleadoPorCedula();
                    break;
                case "3":
                    ListarEmpleadosPorNombre();
                    break;
                case "4":
                    CalcularPromedioSalarios();
                    break;
                case "5":
                    CalcularSalarioMaxMin();
                    break;
                case "6":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    break;
            }
        }
    }


    public void AgregarEmpleado()
    {
        Console.WriteLine("Ingrese los datos del empleado:");
        Console.Write("Cédula: ");
        string cedula = Console.ReadLine();
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Dirección: ");
        string direccion = Console.ReadLine();
        Console.Write("Teléfono: ");
        string telefono = Console.ReadLine();
        Console.Write("Salario: ");
        decimal salario = Convert.ToDecimal(Console.ReadLine());

        Empleado empleado = new Empleado(cedula, nombre, direccion, telefono, salario);
        empleados.Add(empleado);
        Console.WriteLine("Empleado agregado con éxito.");
    }

    public void ConsultarEmpleadoPorCedula()
    {
        Console.Write("Ingrese la cédula del empleado a consultar: ");
        string cedula = Console.ReadLine();

        Empleado empleado = empleados.Find(e => e.GetCedula() == cedula);
        if (empleado != null)
        {
            Console.WriteLine("Información del empleado:");
            empleado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine("Empleado no encontrado.");
        }
    }

    public void ListarEmpleadosPorNombre()
    {
        List<Empleado> empleadosOrdenados = empleados.OrderBy(e => e.GetNombre()).ToList();

        Console.WriteLine("Lista de empleados ordenados por nombre:");
        foreach (Empleado empleado in empleadosOrdenados)
        {
            empleado.MostrarInformacion();
            Console.WriteLine("--------------------");
        }
    }

    public void CalcularPromedioSalarios()
    {
        decimal promedioSalarios = empleados.Average(e => e.GetSalario());
        Console.WriteLine("Promedio de salarios: " + promedioSalarios);
    }

    public void CalcularSalarioMaxMin()
    {
        decimal salarioMaximo = empleados.Max(e => e.GetSalario());
        decimal salarioMinimo = empleados.Min(e => e.GetSalario());

        Console.WriteLine("Salario más alto: " + salarioMaximo);
        Console.WriteLine("Salario más bajo: " + salarioMinimo);
    }

    // Resto de los métodos de la clase Menu...
}

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        menu.Ejecutar();
    }
}
