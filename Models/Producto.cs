namespace Models;

public abstract class Producto
{
     public string Nombre {get;set;}
    public decimal Precio {get;set;}

    public Producto (string nombre, decimal precio)
    {
        Nombre=nombre;
        Precio=precio;
    }

    public void ObtenerProducto()
    {
        Console.WriteLine($"Nombre: {this.Nombre} - Precio: {this.Precio:C2}");
    }
}