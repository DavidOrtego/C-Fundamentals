using Models;
public class Carta
{
    public static void MostrarCarta(List<Producto> productos)
    {
        Console.WriteLine("=== CARTA ===");
        for (int i = 0; i < productos.Count; i++)
        {
            Producto producto = productos[i];
            Console.WriteLine($"{i + 1}. {producto.Nombre} - {producto.Precio:0.##} €");
        }
    }

    public static void ElegirProducto(List<Producto> productos)
    {
        Console.WriteLine("¿Qué producto quieres? ");
        if (!int.TryParse(Console.ReadLine(), out int seleccion))
        {
            Console.WriteLine("Debes introducir un número.");
            return;
        }
        if (seleccion < 1 || seleccion > productos.Count)
        {
            Console.WriteLine("Ese producto no existe.");
            return;
        }
        Console.WriteLine("Has elegido:");
        productos[seleccion - 1].ObtenerProducto();
    }

    public static void BuscarProducto(List<Producto> productos)
    {
        Console.WriteLine("Producto a buscar:");
        String selec = Console.ReadLine();
        List<Producto> productosEncontrados = new List<Producto>();
        int contadorEncontrados = 0;
        foreach (Producto p in productos)
        {
            if (p.Nombre.ToLower().Equals(selec.ToLower()))
            {
                productosEncontrados.Add(p);
                contadorEncontrados++;
            }
        }
        if (contadorEncontrados != 0)
        {
            foreach (Producto p in productosEncontrados)
            {
                p.ObtenerProducto();
            }
        }
        else
        {
            Console.WriteLine("No se ha encontrado el producto.");
        }
    }
    
}