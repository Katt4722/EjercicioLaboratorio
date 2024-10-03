namespace Biblioteca;

public class GrupoEtario
{

    public string Nombre { get; set; }
    public double Edad { get; set; } = 0;
    public GrupoEtario (string nombre, double edad) // Constructor.
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
    public string DeterminarGrupo () // Metodo para la verificacion de edad.
    {
        if (Edad < 0)
        {
            return "El valor ingresado es incorrecto.";
        }
        if (Edad >= 0 && Edad <= 14)
        {
            return "Se encuentra en el grupo etario inactivo.";
        }
        else if (Edad >= 15 && Edad <= 64)
        {
            return "Se encuentra en el grupo activo.";
        }
        else 
        {
            return "Se encuenta en el grupo estario inactivo.";
        }
    }
}
