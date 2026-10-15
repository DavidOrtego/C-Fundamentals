using Microsoft.VisualBasic;

namespace Models;

public class Postre : Producto
{
    public decimal NumCalorias { get; set; }
    public bool IsSugarFree { get; set; }

    public Postre(string name, decimal precio, decimal numCalorias, bool isSugarFree) : base(name, precio)
    {
        NumCalorias = numCalorias;
        IsSugarFree = isSugarFree;
    }

    public void OtenerDescripcion()
    {
        ObtenerProducto();
        string Azucar = IsSugarFree? "Sin Azucar" : "Con Azucar";
        Console.WriteLine($"Numero de caloria: {this.NumCalorias} - Contiene azucar: {Azucar}");
    }
}