using Models;

public class Pedido
{
    public static void AgregarProductoAlPedido(List<Producto>productos, List<Producto>pedido)
    {
        Carta.MostrarCarta(productos);
        Console.WriteLine("¿Qué producto quieres añadir?");
        if (!int.TryParse(Console.ReadLine(), out int idProducto))
        {
            Console.WriteLine("Debes introducir un número.");
            return;
        }
        if (idProducto < 1 || idProducto > productos.Count)
        {
            Console.WriteLine("Ese producto no existe.");
            return;
        }
        pedido.Add(productos[idProducto - 1]);
        Console.WriteLine($"{pedido[idProducto-1].Nombre} añadida al pedido");

    }

    
}