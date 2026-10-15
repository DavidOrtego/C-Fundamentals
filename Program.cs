using Models;

// ## 2. Carta del restaurante
/*
Bebida bebida1= new Bebida("Coca Cola",2,false);
Bebida bebida2 =new Bebida("Agua", 1,false);
PlatoPrincipal platoPrincipal1= new PlatoPrincipal("Paella",12);
PlatoPrincipal platoPrincipal2= new PlatoPrincipal("Chuleton",15);
Postre postre1 = new Postre("Tarta de queso", 4, 200,false);
Postre postre2 = new Postre("Tarta de chocolate", 4, 400, false);
Entrante entrante1 = new Entrante("Patatas bravas", 9, 2, true);
Entrante entrante2 = new Entrante("Ensaladilla rusa", 4, 1, false);

List<Producto> productos = new List<Producto>();
productos.Add(bebida1);
productos.Add(bebida2);
productos.Add(platoPrincipal1);
productos.Add(platoPrincipal2);
productos.Add(postre1);
productos.Add(postre2);
productos.Add(entrante1);
productos.Add(entrante2);
*/
/*
foreach (Producto producto in productos)
{
    producto.ObtenerProducto();
}
*/
/* ## 3. Carta numerada
Console.WriteLine("=== CARTA ===");
foreach (Producto producto in productos)
{
    producto.ObtenerProducto();
}


Console.WriteLine("=== CARTA Numerada ===");
int numeroId = 1;
foreach (Producto producto in productos)
{
    Console.WriteLine(numeroId);
    producto.ObtenerProducto();
    numeroId += 1;
}
*/
/* ## 4. Filtrado por tipo
Console.WriteLine("=== SOLO BEBIDAS ===");
foreach (Producto producto in productos)
{
    if(producto is Bebida)
    {
        producto.ObtenerProducto();
    }
}
*/
/* ## 5. Polimorfismo
Producto producto1 = new Bebida("a",10,true);
Producto producto2 = new Postre("Tarta de queso", 4, 200,false);
Producto producto3 = new Entrante("Ensaladilla rusa", 4, 1, false);

Console.WriteLine(producto1.ObtenerDescripcion());
Console.WriteLine(producto2.ObtenerDescripcion());
Console.WriteLine(producto3.ObtenerDescripcion());
*/

List<Producto> productos = new List<Producto>();
{
   productos.Add(new PlatoPrincipal("Paella", 12));
   productos.Add(new PlatoPrincipal("Chuleton", 15));
   productos.Add(new PlatoPrincipal("Secreto", 8));
};


Console.WriteLine("=== CARTA ===");
for (int i = 0; i < productos.Count; i++)
{
    Producto producto = productos[i];
    Console.WriteLine($"{i + 1}. {producto.Nombre} - {producto.Precio:0.##} €");
}

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

/*
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
if(contadorEncontrados != 0)
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
*/

Console.WriteLine("Producto a buscar por precio max:");
string preciobusqueda = Console.ReadLine();
decimal.TryParse(preciobusqueda, out decimal precioDecimal);
Console.WriteLine($"Productos de hasta {precioDecimal}€:");
int contadorEncontradosPrecioMax = 0;
foreach (Producto p in productos)
{
    if (p.Precio <= precioDecimal)
    {
        p.ObtenerProducto();
        contadorEncontradosPrecioMax++;
    }
}
if (contadorEncontradosPrecioMax != 0)
{
    Console.WriteLine($"No hay productos menores que {precioDecimal}");
}

decimal mayor = 0;
Producto productoMayorPrecio = null;
foreach (Producto p in productos)
{
    if(p.Precio > mayor)
    {
        mayor = p.Precio;
        productoMayorPrecio = p;
    }
}
Console.WriteLine($"El producto más caro es:");
productoMayorPrecio.ObtenerProducto();