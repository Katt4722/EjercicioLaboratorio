namespace Test;
using Biblioteca;
public class grupoEtarioTest
{
    [Fact]
    public void DeterminarGrupo_Eror()
    {
        var grupo = new GrupoEtario("Karen", -10);
        string resultado = grupo.DeterminarGrupo();
        Assert.Equal("El valor ingresado es incorrecto.", resultado);
    }

    [Fact]
    public void DeterminarGrupo_Inactivo()
    {
        var grupo = new GrupoEtario("Sasha", 14);
        string resultado = grupo.DeterminarGrupo();
        Assert.Equal("Se encuentra en el grupo etario inactivo.", resultado);
    }
}