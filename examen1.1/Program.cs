using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Empleado> empleados = new List<Empleado>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Agregar Empleados");
            Console.WriteLine("2. Consultar Empleados por Cédula");
            Console.WriteLine("3. Modificar Empleados por Cédula");
            Console.WriteLine("4. Eliminar Empleados por Cédula");
            Console.WriteLine("5. Listar Empleados por Nombre");
            Console.WriteLine("6. Calcular y Mostrar el Promedio de Salarios");
            Console.WriteLine("7. Calcular y Mostrar el Salario Más Alto y el Más Bajo");
            Console.WriteLine("8. Salir");

            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    AgregarEmpleado();
                    break;
                case "2":

