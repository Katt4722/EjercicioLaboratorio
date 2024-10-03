using Biblioteca;

Console.WriteLine("Ingrese el nombre de la persona: ");
string nombre = Console.ReadLine();

Console.WriteLine("Ingrese la edad de la persona: ");
double edad = 0;

while(double.TryParse(Console.ReadLine(), out edad))
{
    Console.WriteLine("Ingrese una edad valida.");
}

var grupo = new GrupoEtario(nombre, edad);

string resultado = grupo.DeterminarGrupo();
Console.WriteLine(resultado);