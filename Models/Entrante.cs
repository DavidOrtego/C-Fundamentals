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
        if (IsCaliente = true)
        {
            Console.WriteLine($"{Producto.ObtenerProducto()} - Numero de personas: {NPersonas} - Como se sirver: Caliente");
        }
        else
        {
            Console.WriteLine($"{Producto.ObtenerProducto()} - Numero de personas: {NPersonas} - Como se sirver: Frio");
        }
        
    }
}