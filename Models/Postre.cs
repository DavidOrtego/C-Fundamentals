using Microsoft.VisualBasic;

namespace Models;

public class Postre : Producto
{
    public decimal NumCalorias { get; set; }
    public bool IsSugarFree { get; set; }

    public Postre(string name, decimal precio, decimal numCalorias, bool isSugarFree) : base(name, precio, ingredientes)
    {
        NumCalorias = numCalorias;
        IsSugarFree = isSugarFree;
    }

}