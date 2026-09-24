using Microsoft.VisualBasic;

namespace Models;

public class Bebida : Producto
{
    public bool IsAlcoholica { get; set; }

    public Bebida(string name, decimal precio, bool isAlcoholica) : base(name, precio, ingredientes)
    {
        IsAlcoholica = isAlcoholica;
    }

}