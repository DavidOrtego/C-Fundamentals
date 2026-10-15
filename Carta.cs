using Models;
public class Carta
{
    public static void mostrarCarta(List<Producto> carta)
    {
        foreach (Producto producto in carta)
        {
            producto.ObtenerProducto();
        }
    }
    
}