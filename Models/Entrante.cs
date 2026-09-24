namespace Models;

public class Entrante : Producto
{
    public int NPersonas {get; set;}
    public bool IsCaliente {get;set;}

    public Entrante(string nombre, decimal precio, int npersonas, bool iscaliente)
    : base(nombre, precio)
    {
        NPersonas=npersonas;
        IsCaliente=iscaliente;
    }

    public void OtenerDescripcion()
    {
        ObtenerProducto();

        string temperatura = IsCaliente ? "Caliente" : "Frio";
        Console.WriteLine($"Numero de personas: {NPersonas} - Como se sirve: {temperatura}");
    }
}