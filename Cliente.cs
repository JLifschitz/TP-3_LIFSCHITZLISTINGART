public class Cliente
{
    public int DNI{get; private set;}
    public string Nombre{get; private set;}
    public string Apellido{get; private set;}
    public DateTime FechaInscripcion{get;set;}
    public int TipoEntrada{get;set;}
    public int TotalAbonado{get;set;}

    public Cliente(int dni, string nombre, string apellido, int tipoEntrada, int totalAbonado)
    {
        DNI = dni;
        Nombre = nombre;
        Apellido = apellido;
        TipoEntrada=tipoEntrada;
        TotalAbonado=totalAbonado;
    }
}