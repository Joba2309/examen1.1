using System;

class Empleado
{
    // Atributos
    private string cedula;
    private string nombre;
    private string direccion;
    private string telefono;
    private decimal salario;

    // Constructor
    public Empleado(string cedula, string nombre, string direccion, string telefono, decimal salario)
    {
        this.cedula = cedula;
        this.nombre = nombre;
        this.direccion = direccion;
        this.telefono = telefono;
        this.salario = salario;
    }

    // Métodos de acceso (getters y setters)
    public string GetCedula()
    {
        return cedula;
    }

    public void SetCedula(string cedula)
    {
        this.cedula = cedula;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public string GetDireccion()
    {
        return direccion;
    }

    public void SetDireccion(string direccion)
    {
        this.direccion = direccion;
    }

    public string GetTelefono()
    {
        return telefono;
    }

    public void SetTelefono(string telefono)
    {
        this.telefono = telefono;
    }

    public decimal GetSalario()
    {
        return salario;
    }

    public void SetSalario(decimal salario)
    {
        this.salario = salario;
    }
}




