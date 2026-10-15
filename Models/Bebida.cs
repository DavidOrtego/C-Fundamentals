using Microsoft.VisualBasic;

namespace Models;

public class Bebida : Producto
{
    public bool IsAlcoholica { get; set; }

    public Bebida(string name, decimal precio, bool isAlcoholica) : base(name, precio)
    {
        IsAlcoholica = isAlcoholica;
    }

    public void OtenerDescripcion()
    {
        ObtenerProducto();
        string Alochol = IsAlcoholica? "Si" : "No";
        Console.WriteLine($"Contiene alcohol: {Alochol}");
    }
}