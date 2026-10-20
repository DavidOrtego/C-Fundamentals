using Models;

public class Pedido
{
    public static void AgregarProductoAlPedido(List<Producto> productos, List<Producto> pedido)
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
        Console.WriteLine($"{pedido[pedido.Count - 1].Nombre} añadida al pedido");

    }

    public static void MostrarPedido(List<Producto> pedido)
    {

        if (pedido.Count == 0)
        {
            Console.WriteLine("El pedido está vacío");
        }
        else
        {
            Console.WriteLine("=== Tu Pedido ===");
            decimal total = 0;
            foreach (Producto p in pedido)
            {
                Console.WriteLine($"{p.Nombre}   {p.Precio}");
                total = total + p.Precio;
            }
            Console.WriteLine($"---------------------");
            Console.WriteLine($"TOTAL:     {total}");
        }
    }

    public static void EliminarProductoDelPedido(List<Producto> pedido)
    {
        if (pedido.Count == 0)
        {
            Console.WriteLine("El pedido está vacío");
        }
        else
        {
            int idPedido = 0;
            Console.WriteLine("=== Tu Pedido ===");
            foreach (Producto p in pedido)
            {
                idPedido++;
                Console.WriteLine($"{idPedido}.  {p.Nombre}   {p.Precio}");

            }
            Console.WriteLine("¿Qué producto quieres eliminar?");
            if (!int.TryParse(Console.ReadLine(), out int idPedidoEli))
            {
                Console.WriteLine("Debes introducir un número.");
                return;
            }
            if (idPedidoEli < 1 || idPedidoEli > pedido.Count)
            {
                Console.WriteLine("Ese producto no existe.");
                return;
            }
            Console.WriteLine($"{pedido[idPedidoEli-1].Nombre} eliminado del pedido.");
            pedido.RemoveAt(idPedidoEli - 1);
        }
    }
}