using Models;

Console.WriteLine("Hello, World!");


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